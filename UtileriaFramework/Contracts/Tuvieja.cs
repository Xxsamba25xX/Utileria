using System;
using System.Collections.Generic;
using System.Text;

namespace UtileriaFramework.Contracts
{

	// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.xmlsoap.org/soap/envelope/", IsNullable = false)]
	public partial class Envelope
	{

		private EnvelopeBody bodyField;

		/// <remarks/>
		public EnvelopeBody Body
		{
			get
			{
				return this.bodyField;
			}
			set
			{
				this.bodyField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
	public partial class EnvelopeBody
	{

		private doBookingResponse doBookingResponseField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://ws_2013.services.cangooroo.net/")]
		public doBookingResponse doBookingResponse
		{
			get
			{
				return this.doBookingResponseField;
			}
			set
			{
				this.doBookingResponseField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ws_2013.services.cangooroo.net/")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://ws_2013.services.cangooroo.net/", IsNullable = false)]
	public partial class doBookingResponse
	{

		private doBookingResponseDoBookingResult doBookingResultField;

		/// <remarks/>
		public doBookingResponseDoBookingResult doBookingResult
		{
			get
			{
				return this.doBookingResultField;
			}
			set
			{
				this.doBookingResultField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ws_2013.services.cangooroo.net/")]
	public partial class doBookingResponseDoBookingResult
	{

		private ushort bookingNumberField;

		private ushort clientIDField;

		private string clientNameField;

		private string operatorNameField;

		private byte numberOfBookingRoomsField;

		private byte baseIDField;

		private byte cNPJField;

		private Rooms roomsField;

		private object transfersField;

		private object toursField;

		private object carsField;

		private object trainTicketsField;

		private object trainPassField;

		private object insurancesField;

		private object circuitoField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "Cangooroo.WS_2013")]
		public ushort BookingNumber
		{
			get
			{
				return this.bookingNumberField;
			}
			set
			{
				this.bookingNumberField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "Cangooroo.WS_2013")]
		public ushort ClientID
		{
			get
			{
				return this.clientIDField;
			}
			set
			{
				this.clientIDField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "Cangooroo.WS_2013")]
		public string ClientName
		{
			get
			{
				return this.clientNameField;
			}
			set
			{
				this.clientNameField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "Cangooroo.WS_2013")]
		public string OperatorName
		{
			get
			{
				return this.operatorNameField;
			}
			set
			{
				this.operatorNameField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "Cangooroo.WS_2013")]
		public byte NumberOfBookingRooms
		{
			get
			{
				return this.numberOfBookingRoomsField;
			}
			set
			{
				this.numberOfBookingRoomsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "Cangooroo.WS_2013")]
		public byte BaseID
		{
			get
			{
				return this.baseIDField;
			}
			set
			{
				this.baseIDField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "Cangooroo.WS_2013")]
		public byte CNPJ
		{
			get
			{
				return this.cNPJField;
			}
			set
			{
				this.cNPJField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "Cangooroo.WS_2013")]
		public Rooms Rooms
		{
			get
			{
				return this.roomsField;
			}
			set
			{
				this.roomsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "Cangooroo.WS_2013")]
		public object Transfers
		{
			get
			{
				return this.transfersField;
			}
			set
			{
				this.transfersField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "Cangooroo.WS_2013")]
		public object Tours
		{
			get
			{
				return this.toursField;
			}
			set
			{
				this.toursField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "Cangooroo.WS_2013")]
		public object Cars
		{
			get
			{
				return this.carsField;
			}
			set
			{
				this.carsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "Cangooroo.WS_2013")]
		public object TrainTickets
		{
			get
			{
				return this.trainTicketsField;
			}
			set
			{
				this.trainTicketsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "Cangooroo.WS_2013")]
		public object TrainPass
		{
			get
			{
				return this.trainPassField;
			}
			set
			{
				this.trainPassField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "Cangooroo.WS_2013")]
		public object Insurances
		{
			get
			{
				return this.insurancesField;
			}
			set
			{
				this.insurancesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "Cangooroo.WS_2013")]
		public object Circuito
		{
			get
			{
				return this.circuitoField;
			}
			set
			{
				this.circuitoField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "Cangooroo.WS_2013")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "Cangooroo.WS_2013", IsNullable = false)]
	public partial class Rooms
	{

		private RoomsHotelBookingRoomResult_d hotelBookingRoomResult_dField;

		/// <remarks/>
		public RoomsHotelBookingRoomResult_d HotelBookingRoomResult_d
		{
			get
			{
				return this.hotelBookingRoomResult_dField;
			}
			set
			{
				this.hotelBookingRoomResult_dField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "Cangooroo.WS_2013")]
	public partial class RoomsHotelBookingRoomResult_d
	{

		private string bookingDescriptionField;

		private bool cancelationBlockWSField;

		private string boardDescriptionField;

		private bool breakfastIncludedField;

		private byte hotelCategoryField;

		private uint cityIdField;

		private byte agencyCommissionField;

		private System.DateTime cancellationDateField;

		private System.DateTime checkInDateField;

		private System.DateTime paymentDeadlineField;

		private System.DateTime reservationDateField;

		private string hotelAddressField;

		private uint hotelIdField;

		private ushort serviceIdField;

		private string locationField;

		private string logXMLAuditIdField;

		private string agencyCurrencyCommissionField;

		private string cityNameField;

		private string hotelNameField;

		private byte numberOfAdultsField;

		private byte numberOfChildrenField;

		private byte numberOfNightsField;

		private string observationField;

		private string voucherObservationField;

		private string countryIdField;

		private PaxsPax[] paxsField;

		private NetPrice netPriceField;

		private OperatorCancellationPolicies operatorCancellationPoliciesField;

		private ushort reservationIdField;

		private string roomDescriptionField;

		private string paymentStatusField;

		private string systemStatusField;

		private byte conversionRateField;

		private string hotelPhoneField;

		private string providerIDField;

		private string providerNameField;

		private string providerLogoField;

		private string providerBookingCodeField;

		private System.DateTime paymentDateField;

		private string paymentTypeField;

		private object remarksField;

		private CreationUserDetail creationUserDetailField;

		private LastUpdateUserDetail lastUpdateUserDetailField;

		private object paymentsField;

		private string urlVoucherField;

		private object hotelCNPJField;

		private object roomClientReferenceField;

	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "WS_2013.Hotel")]
	public partial class PaxsPax
	{

		private byte addressNumberField;

		private byte dDIField;

		private byte dDDField;

		private byte phoneNumberField;

		private System.DateTime birthdayField;

		private string nameField;

		private string lastNameField;

		private byte ageField;

		private string enumTitleField;

		private string enumPaxTypeField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Common")]
		public byte AddressNumber
		{
			get
			{
				return this.addressNumberField;
			}
			set
			{
				this.addressNumberField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Common")]
		public byte DDI
		{
			get
			{
				return this.dDIField;
			}
			set
			{
				this.dDIField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Common")]
		public byte DDD
		{
			get
			{
				return this.dDDField;
			}
			set
			{
				this.dDDField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Common")]
		public byte PhoneNumber
		{
			get
			{
				return this.phoneNumberField;
			}
			set
			{
				this.phoneNumberField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Common")]
		public System.DateTime Birthday
		{
			get
			{
				return this.birthdayField;
			}
			set
			{
				this.birthdayField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Common")]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Common")]
		public string LastName
		{
			get
			{
				return this.lastNameField;
			}
			set
			{
				this.lastNameField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Common")]
		public byte Age
		{
			get
			{
				return this.ageField;
			}
			set
			{
				this.ageField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Common")]
		public string EnumTitle
		{
			get
			{
				return this.enumTitleField;
			}
			set
			{
				this.enumTitleField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Common")]
		public string EnumPaxType
		{
			get
			{
				return this.enumPaxTypeField;
			}
			set
			{
				this.enumPaxTypeField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "WS_2013.Hotel")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "WS_2013.Hotel", IsNullable = false)]
	public partial class NetPrice
	{

		private string currencyField;

		private decimal valueField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013")]
		public string Currency
		{
			get
			{
				return this.currencyField;
			}
			set
			{
				this.currencyField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013")]
		public decimal Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "WS_2013.Hotel")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "WS_2013.Hotel", IsNullable = false)]
	public partial class OperatorCancellationPolicies
	{

		private OperatorCancellationPoliciesCancellationPolicy cancellationPolicyField;

		/// <remarks/>
		public OperatorCancellationPoliciesCancellationPolicy CancellationPolicy
		{
			get
			{
				return this.cancellationPolicyField;
			}
			set
			{
				this.cancellationPolicyField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "WS_2013.Hotel")]
	public partial class OperatorCancellationPoliciesCancellationPolicy
	{

		private System.DateTime startDateField;

		private System.DateTime endDateField;

		private Price priceField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Common")]
		public System.DateTime StartDate
		{
			get
			{
				return this.startDateField;
			}
			set
			{
				this.startDateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Common")]
		public System.DateTime EndDate
		{
			get
			{
				return this.endDateField;
			}
			set
			{
				this.endDateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Common")]
		public Price Price
		{
			get
			{
				return this.priceField;
			}
			set
			{
				this.priceField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "WS_2013.Common")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "WS_2013.Common", IsNullable = false)]
	public partial class Price
	{

		private string currencyField;

		private decimal valueField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013")]
		public string Currency
		{
			get
			{
				return this.currencyField;
			}
			set
			{
				this.currencyField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013")]
		public decimal Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "WS_2013.Hotel")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "WS_2013.Hotel", IsNullable = false)]
	public partial class CreationUserDetail
	{

		private string nameField;

		private ushort idField;

		private string userNameField;

		private string emailField;

		/// <remarks/>
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		/// <remarks/>
		public ushort Id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		/// <remarks/>
		public string UserName
		{
			get
			{
				return this.userNameField;
			}
			set
			{
				this.userNameField = value;
			}
		}

		/// <remarks/>
		public string Email
		{
			get
			{
				return this.emailField;
			}
			set
			{
				this.emailField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "WS_2013.Hotel")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "WS_2013.Hotel", IsNullable = false)]
	public partial class LastUpdateUserDetail
	{

		private string nameField;

		private ushort idField;

		private string userNameField;

		private string emailField;

		/// <remarks/>
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		/// <remarks/>
		public ushort Id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		/// <remarks/>
		public string UserName
		{
			get
			{
				return this.userNameField;
			}
			set
			{
				this.userNameField = value;
			}
		}

		/// <remarks/>
		public string Email
		{
			get
			{
				return this.emailField;
			}
			set
			{
				this.emailField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "WS_2013.Hotel")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "WS_2013.Hotel", IsNullable = false)]
	public partial class Paxs
	{

		private PaxsPax[] paxField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Pax")]
		public PaxsPax[] Pax
		{
			get
			{
				return this.paxField;
			}
			set
			{
				this.paxField = value;
			}
		}
	}


}
