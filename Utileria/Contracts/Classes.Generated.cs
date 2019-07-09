namespace Utileria.Contracts
{
	using System;
	using System.Collections.Generic;
	using System.Text;


	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(ElementName = "Root", Namespace = "", IsNullable = false)]
	public partial class GetHotelInfoResponse
	{

		private GetHotelInfoResponseHeader headerField;

		private GetHotelInfoResponseMain mainField;

		/// <remarks/>
		public GetHotelInfoResponseHeader Header
		{
			get
			{
				return this.headerField;
			}
			set
			{
				this.headerField = value;
			}
		}

		/// <remarks/>
		public GetHotelInfoResponseMain Main
		{
			get
			{
				return this.mainField;
			}
			set
			{
				this.mainField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(ElementName = "Header", Namespace = "", IsNullable = false)]
	public partial class GetHotelInfoResponseHeader
	{

		private string agencyField;

		private string userField;

		private string passwordField;

		private string operationField;

		private string operationTypeField;

		/// <remarks/>
		public string Agency
		{
			get
			{
				return this.agencyField;
			}
			set
			{
				this.agencyField = value;
			}
		}

		/// <remarks/>
		public string User
		{
			get
			{
				return this.userField;
			}
			set
			{
				this.userField = value;
			}
		}

		/// <remarks/>
		public string Password
		{
			get
			{
				return this.passwordField;
			}
			set
			{
				this.passwordField = value;
			}
		}

		/// <remarks/>
		public string Operation
		{
			get
			{
				return this.operationField;
			}
			set
			{
				this.operationField = value;
			}
		}

		/// <remarks/>
		public string OperationType
		{
			get
			{
				return this.operationTypeField;
			}
			set
			{
				this.operationTypeField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]

	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(ElementName = "Main", Namespace = "", IsNullable = false)]
	public partial class GetHotelInfoResponseMain
	{

		private string hotelSearchCodeField;

		private string hotelNameField;

		private string addressField;

		private int cityCodeField;

		private GetHotelInfoResponseMainGeoCodes geoCodesField;

		private string phoneField;

		private string faxField;

		private string categoryField;

		private string descriptionField;

		private string hotelFacilitiesField;

		private string roomFacilitiesField;

		private string roomCountField;

		private GetHotelInfoResponseMainPicture[] picturesField;

		/// <remarks/>
		public string HotelSearchCode
		{
			get
			{
				return this.hotelSearchCodeField;
			}
			set
			{
				this.hotelSearchCodeField = value;
			}
		}

		/// <remarks/>
		public string HotelName
		{
			get
			{
				return this.hotelNameField;
			}
			set
			{
				this.hotelNameField = value;
			}
		}

		/// <remarks/>
		public string Address
		{
			get
			{
				return this.addressField;
			}
			set
			{
				this.addressField = value;
			}
		}

		/// <remarks/>
		public int CityCode
		{
			get
			{
				return this.cityCodeField;
			}
			set
			{
				this.cityCodeField = value;
			}
		}

		/// <remarks/>
		public GetHotelInfoResponseMainGeoCodes GeoCodes
		{
			get
			{
				return this.geoCodesField;
			}
			set
			{
				this.geoCodesField = value;
			}
		}

		/// <remarks/>
		public string Phone
		{
			get
			{
				return this.phoneField;
			}
			set
			{
				this.phoneField = value;
			}
		}

		/// <remarks/>
		public string Fax
		{
			get
			{
				return this.faxField;
			}
			set
			{
				this.faxField = value;
			}
		}

		/// <remarks/>
		public string Category
		{
			get
			{
				return this.categoryField;
			}
			set
			{
				this.categoryField = value;
			}
		}

		/// <remarks/>
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}

		/// <remarks/>
		public string HotelFacilities
		{
			get
			{
				return this.hotelFacilitiesField;
			}
			set
			{
				this.hotelFacilitiesField = value;
			}
		}

		/// <remarks/>
		public string RoomFacilities
		{
			get
			{
				return this.roomFacilitiesField;
			}
			set
			{
				this.roomFacilitiesField = value;
			}
		}

		/// <remarks/>
		public string RoomCount
		{
			get
			{
				return this.roomCountField;
			}
			set
			{
				this.roomCountField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayItemAttribute("Picture", IsNullable = false)]
		public GetHotelInfoResponseMainPicture[] Pictures
		{
			get
			{
				return this.picturesField;
			}
			set
			{
				this.picturesField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]

	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(ElementName = "GeoCodes", Namespace = "", IsNullable = false)]
	public partial class GetHotelInfoResponseMainGeoCodes
	{

		private string longitudeField;

		private string latitudeField;

		/// <remarks/>
		public string Longitude
		{
			get
			{
				return this.longitudeField;
			}
			set
			{
				this.longitudeField = value;
			}
		}

		/// <remarks/>
		public string Latitude
		{
			get
			{
				return this.latitudeField;
			}
			set
			{
				this.latitudeField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]

	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(ElementName = "Picture", Namespace = "", IsNullable = false)]
	public partial class GetHotelInfoResponseMainPicture
	{

		private string descriptionField;

		private string valueField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		public string Value
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


}

