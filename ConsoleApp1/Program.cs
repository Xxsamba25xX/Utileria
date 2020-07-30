using ConsoleApp1.TravelgatexHotel.Domain.Request;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, RowEntry> entries = new Dictionary<string, RowEntry>();
            Directory.Delete("output", true);

            var lines = File.ReadAllLines("Entries.txt");
            foreach (var line in lines)
            {
                var splitted = line.Split("\t", StringSplitOptions.RemoveEmptyEntries);
                entries.Add(splitted[0], new RowEntry()
                {
                    Clase = splitted[0],
                    Categoria = splitted[1],
                    Tipo = splitted[2],
                    Dependencias = splitted[3]
                });
            }

            var callDependency = File.ReadAllText("CallDependency.txt");
            var removeDependencyService = File.ReadAllText("RemoveDependencyService.txt");
            var useCase = File.ReadAllText("UseCase.txt");
            var iuseCase = File.ReadAllText("IUseCase.txt");

            foreach (var entry in entries.Values)
            {
                var dependencias = entry.Dependencias.Split(",");
                var sbUsing = new StringBuilder();
                var sbVarDec = new StringBuilder();
                var sbParamDec = new StringBuilder();
                var sbVarXParam = new StringBuilder();
                var sbcallDependencies = new StringBuilder();
                var sbRemoveDependencyService = new StringBuilder();

                sbUsing.AppendLine($"using NegotisService.UseCase.{entry.Categoria}.Contracts;");
                sbVarDec.AppendLine($"public readonly I{entry.Clase}Service _{entry.Clase.ToLower()}Service;");
                sbParamDec.Append($"I{entry.Clase}Service {entry.Clase.ToLower()}Service").Append(", ");
                sbVarXParam.AppendLine($"_{entry.Clase.ToLower()}Service = {entry.Clase.ToLower()}Service;");


                foreach (var item in dependencias)
                {
                    if (entries.ContainsKey(item))
                    {
                        RowEntry objDep = entries[item];
                        sbUsing.AppendLine($"using NegotisService.UseCase.{objDep.Categoria}.Contracts;");

                        sbVarDec.AppendLine($"public readonly IEliminarDependencias{item}UseCase _eliminarDependencias{item}UseCase;");
                        sbParamDec.Append($"IEliminarDependencias{item}UseCase eliminarDependencias{item}UseCase").Append(", ");
                        sbVarXParam.AppendLine($"_eliminarDependencias{item}UseCase = eliminarDependencias{item}UseCase;");

                        var callDependencyImpl = callDependency;
                        callDependencyImpl = callDependencyImpl.Replace("$tipo", objDep.Tipo);
                        callDependencyImpl = callDependencyImpl.Replace("$claseLower", item.ToLower());
                        callDependencyImpl = callDependencyImpl.Replace("$clase", item);
                        callDependencyImpl = callDependencyImpl.Replace("$padre", entry.Clase);
                        sbcallDependencies.AppendLine(callDependencyImpl);
                    }
                    else
                    {
                        var removeDependencyServiceImpl = removeDependencyService;
                        removeDependencyServiceImpl = removeDependencyServiceImpl.Replace("$nombreHijo", item);
                        removeDependencyServiceImpl = removeDependencyServiceImpl.Replace("$minusNombreHijo", item.ToLower());
                        removeDependencyServiceImpl = removeDependencyServiceImpl.Replace("$nombrePadre", entry.Clase);
                        removeDependencyServiceImpl = removeDependencyServiceImpl.Replace("$padre", entry.Clase);
                        sbRemoveDependencyService.AppendLine(removeDependencyServiceImpl);
                    }

                    sbVarDec.AppendLine($"public readonly I{item}Service _{item.ToLower()}Service;");
                    sbParamDec.Append($"I{item}Service {item.ToLower()}Service").Append(", ");
                    sbVarXParam.AppendLine($"_{item.ToLower()}Service = {item.ToLower()}Service;");
                }

                sbcallDependencies.Append(sbRemoveDependencyService.ToString());

                var useCaseImpl = useCase;
                useCaseImpl = useCaseImpl.Replace("$Using", sbUsing.ToString());
                useCaseImpl = useCaseImpl.Replace("$Categoria", entry.Categoria);
                useCaseImpl = useCaseImpl.Replace("$NombrePadre", entry.Clase);
                useCaseImpl = useCaseImpl.Replace("$VarDec", sbVarDec.ToString());
                useCaseImpl = useCaseImpl.Replace("$ParamDec", sbParamDec.ToString().TrimEnd(',', ' '));
                useCaseImpl = useCaseImpl.Replace("$VarParam", sbVarXParam.ToString());
                useCaseImpl = useCaseImpl.Replace("$Tipo", entry.Tipo);
                useCaseImpl = useCaseImpl.Replace("$DeleteHijos", sbcallDependencies.ToString());
                useCaseImpl = useCaseImpl.Replace("$NombreMinusculas", entry.Clase.ToLower());

                var iuseCaseImpl = iuseCase;
                iuseCaseImpl = iuseCaseImpl.Replace("$Categoria", entry.Categoria);
                iuseCaseImpl = iuseCaseImpl.Replace("$NombrePadre", entry.Clase);
                iuseCaseImpl = iuseCaseImpl.Replace("$Tipo", entry.Tipo);

                Directory.CreateDirectory(Path.Combine("output", entry.Categoria, "Contracts"));
                File.WriteAllText(Path.Combine("output", entry.Categoria, $"EliminarDependencias{entry.Clase}UseCase.cs"), useCaseImpl);
                File.WriteAllText(Path.Combine("output", entry.Categoria, "Contracts", $"IEliminarDependencias{entry.Clase}UseCase.cs"), iuseCaseImpl);

                Console.WriteLine($"{entry.Categoria}");
                Console.WriteLine($"container.RegisterType<IEliminarDependencias{entry.Clase}UseCase, EliminarDependencias{entry.Clase}UseCase>();");
            }

        }
    }


    public class RowEntry
    {
        public string Clase { get; set; }
        public string Categoria { get; set; }
        public string Tipo { get; set; }
        public string Dependencias { get; set; }
    }
}
