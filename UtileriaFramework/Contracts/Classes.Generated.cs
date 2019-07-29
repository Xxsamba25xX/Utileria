namespace CangoorooHotelProvider.XMLHelpers.Generated
{

	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "Cangooroo.WS_2013")]
	public partial class Rooms
	{
		[System.Xml.Serialization.XmlElement(ElementName = "HotelBookingRoomResult_d", Type = typeof(HotelBookingRoomResult_d), Namespace = "Cangooroo.WS_2013")]
		[System.Xml.Serialization.XmlElement(ElementName = "RoomBooking_b", Type = typeof(RoomBooking_b), Namespace = "WS_2013.Hotel")]
		[System.Xml.Serialization.XmlElement(ElementName = "SearchRoom", Type = typeof(SearchRoom), Namespace = "WS_2013.Hotel")]
		[System.Xml.Serialization.XmlElement(ElementName = "RoomResultCancellationPolicies_b", Type = typeof(RoomResultCancellationPolicies_b), Namespace = "Cangooroo.WS_2013.Hotel")]
		[System.Xml.Serialization.XmlElement(ElementName = "RoomResultMGM_e", Type = typeof(RoomResultMGM_e), Namespace = "Cangooroo.WS_2013.Hotel")]
		[System.Xml.Serialization.XmlElement(ElementName = "HotelBookingRoomResult_j", Type = typeof(HotelBookingRoomResult_j), Namespace = "Cangooroo.WS_2013")]
		public object[] Item { get; set; }
	}
	//---------------------------------// SearchRQ //---------------------------------------------//
	//// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.xmlsoap.org/soap/envelope/", IsNullable = false)]
	public partial class Envelope
	{

		private Header headerField;

		private Body bodyField;

		//// <remarks/>
		public Header Header
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

		//// <remarks/>
		public Body Body
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

	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
	public partial class Header
	{
	}

	//// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
	public partial class Body
	{

		private searchAvailability searchAvailabilityField;

		private searchAvailabilityResponse searchAvailabilityResponseField;

		private getCancellationPolicies getCancellationPoliciesField;

		private getCancellationPoliciesResponse getCancellationPoliciesResponseField;

		private doBooking doBookingField;

		private doBookingResponse doBookingResponseField;

		private cancelBooking cancelBookingField;

		private cancelBookingResponse cancelBookingResponseField;

		private getBookingDetail getBookingDetailField;

		private getBookingList getBookingListField;

		private getBookingListResponse getBookingListResponseField;

		private getBookingDetailResponse getBookingDetailResponseField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://tempuri.org/")]
		public getBookingDetailResponse getBookingDetailResponse
		{
			get
			{
				return this.getBookingDetailResponseField;
			}
			set
			{
				this.getBookingDetailResponseField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://ws_2013.services.cangooroo.net/")]
		public getBookingListResponse getBookingListResponse
		{
			get
			{
				return this.getBookingListResponseField;
			}
			set
			{
				this.getBookingListResponseField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://ws_2013.services.cangooroo.net/")]
		public getBookingList getBookingList
		{
			get
			{
				return this.getBookingListField;
			}
			set
			{
				this.getBookingListField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://tempuri.org/")]
		public getBookingDetail getBookingDetail
		{
			get
			{
				return this.getBookingDetailField;
			}
			set
			{
				this.getBookingDetailField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://ws_2013.services.cangooroo.net/")]
		public searchAvailability searchAvailability
		{
			get
			{
				return this.searchAvailabilityField;
			}
			set
			{
				this.searchAvailabilityField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://ws_2013.services.cangooroo.net/")]
		public searchAvailabilityResponse searchAvailabilityResponse
		{
			get
			{
				return this.searchAvailabilityResponseField;
			}
			set
			{
				this.searchAvailabilityResponseField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://ws_2013.services.cangooroo.net/")]
		public getCancellationPolicies getCancellationPolicies
		{
			get
			{
				return this.getCancellationPoliciesField;
			}
			set
			{
				this.getCancellationPoliciesField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://ws_2013.services.cangooroo.net/")]
		public getCancellationPoliciesResponse getCancellationPoliciesResponse
		{
			get
			{
				return this.getCancellationPoliciesResponseField;
			}
			set
			{
				this.getCancellationPoliciesResponseField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://ws_2013.services.cangooroo.net/")]
		public doBooking doBooking
		{
			get
			{
				return this.doBookingField;
			}
			set
			{
				this.doBookingField = value;
			}
		}

		//// <remarks/>
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

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://ws_2013.services.cangooroo.net/")]
		public cancelBooking cancelBooking
		{
			get
			{
				return this.cancelBookingField;
			}
			set
			{
				this.cancelBookingField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://ws_2013.services.cangooroo.net/")]
		public cancelBookingResponse cancelBookingResponse
		{
			get
			{
				return this.cancelBookingResponseField;
			}
			set
			{
				this.cancelBookingResponseField = value;
			}
		}
	}

	//// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ws_2013.services.cangooroo.net/")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://ws_2013.services.cangooroo.net/", IsNullable = false)]
	public partial class searchAvailability
	{

		private Credential credentialField;

		private Criteria criteriaField;

		//// <remarks/>
		public Credential credential
		{
			get
			{
				return this.credentialField;
			}
			set
			{
				this.credentialField = value;
			}
		}

		//// <remarks/>
		public Criteria criteria
		{
			get
			{
				return this.criteriaField;
			}
			set
			{
				this.criteriaField = value;
			}
		}
	}

	//// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ws_2013.services.cangooroo.net/")]
	public partial class Credential
	{

		private string userNameField;

		private string passwordField;

		private string clientIdField;

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.ClientCredential")]
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

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.ClientCredential")]
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
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.ClientCredential")]
		public string ClientId
		{
			get
			{
				return this.clientIdField;
			}
			set
			{
				this.clientIdField = value;
			}
		}
	}

	//// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ws_2013.services.cangooroo.net/")]
	public partial class Criteria
	{
		private Rooms roomsField;

		private int cityIdField;

		private System.DateTime checkInDateField;

		private int numberOfNightsField;

		private string accomodationSearchTypeField;

		private bool returnRoomOnRequestField;

		//// <remarks/>
		[System.Xml.Serialization.XmlElement(Namespace = "WS_2013.Hotel")]
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

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public int CityId
		{
			get
			{
				return this.cityIdField;
			}
			set
			{
				this.cityIdField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public System.DateTime CheckInDate
		{
			get
			{
				return this.checkInDateField;
			}
			set
			{
				this.checkInDateField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public int NumberOfNights
		{
			get
			{
				return this.numberOfNightsField;
			}
			set
			{
				this.numberOfNightsField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string AccomodationSearchType
		{
			get
			{
				return this.accomodationSearchTypeField;
			}
			set
			{
				this.accomodationSearchTypeField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public bool ReturnRoomOnRequest
		{
			get
			{
				return this.returnRoomOnRequestField;
			}
			set
			{
				this.returnRoomOnRequestField = value;
			}
		}
	}

	//// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "WS_2013.Hotel")]
	public partial class SearchRoom
	{

		private byte quantityField;

		private short qtyAdultsField;

		private int[] ageOfTheChildrensField;

		//// <remarks/>
		public byte Quantity
		{
			get
			{
				return this.quantityField;
			}
			set
			{
				this.quantityField = value;
			}
		}

		//// <remarks/>
		public short QtyAdults
		{
			get
			{
				return this.qtyAdultsField;
			}
			set
			{
				this.qtyAdultsField = value;
			}
		}

		//// <remarks/>
		public int[] AgeOfTheChildrens
		{
			get
			{
				return this.ageOfTheChildrensField;
			}
			set
			{
				this.ageOfTheChildrensField = value;
			}
		}
	}

	//---------------------------------// SearchRS //---------------------------------------------//

	//// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ws_2013.services.cangooroo.net/")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://ws_2013.services.cangooroo.net/", IsNullable = false)]
	public partial class searchAvailabilityResponse
	{

		private SearchAvailabilityResult searchAvailabilityResultField;

		//// <remarks/>
		public SearchAvailabilityResult searchAvailabilityResult
		{
			get
			{
				return this.searchAvailabilityResultField;
			}
			set
			{
				this.searchAvailabilityResultField = value;
			}
		}
	}

	//// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ws_2013.services.cangooroo.net/")]
	public partial class SearchAvailabilityResult
	{

		private string tokenField;

		private object completeSearchTokenField;

		private decimal totalTimeField;

		private bool searchCompletedField;

		private byte numberOfTotalResultsField;

		private byte numberOfResultsAfterFilterField;

		private byte numberOfResultsOnThisRespField;

		private HotelResultMGM_e[] hotelsField;

		private object convertionsField;

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string Token
		{
			get
			{
				return this.tokenField;
			}
			set
			{
				this.tokenField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public object CompleteSearchToken
		{
			get
			{
				return this.completeSearchTokenField;
			}
			set
			{
				this.completeSearchTokenField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public decimal TotalTime
		{
			get
			{
				return this.totalTimeField;
			}
			set
			{
				this.totalTimeField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public bool SearchCompleted
		{
			get
			{
				return this.searchCompletedField;
			}
			set
			{
				this.searchCompletedField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public byte NumberOfTotalResults
		{
			get
			{
				return this.numberOfTotalResultsField;
			}
			set
			{
				this.numberOfTotalResultsField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public byte NumberOfResultsAfterFilter
		{
			get
			{
				return this.numberOfResultsAfterFilterField;
			}
			set
			{
				this.numberOfResultsAfterFilterField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public byte NumberOfResultsOnThisResp
		{
			get
			{
				return this.numberOfResultsOnThisRespField;
			}
			set
			{
				this.numberOfResultsOnThisRespField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlArrayAttribute(Namespace = "WS_2013.Hotel")]
		[System.Xml.Serialization.XmlArrayItem("HotelResultMGM_e")]
		public HotelResultMGM_e[] Hotels
		{
			get
			{
				return this.hotelsField;
			}
			set
			{
				this.hotelsField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public object Convertions
		{
			get
			{
				return this.convertionsField;
			}
			set
			{
				this.convertionsField = value;
			}
		}
	}

	////// <remarks/>
	//[System.SerializableAttribute()]
	//[System.ComponentModel.DesignerCategoryAttribute("code")]
	//[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "WS_2013.Hotel")]
	//[System.Xml.Serialization.XmlRootAttribute(Namespace = "WS_2013.Hotel", IsNullable = false)]
	//public partial class Hotels
	//{

	//	private HotelResultMGM_e hotelResultMGM_eField;

	//	//// <remarks/>
	//	public HotelResultMGM_e HotelResultMGM_e
	//	{
	//		get
	//		{
	//			return this.hotelResultMGM_eField;
	//		}
	//		set
	//		{
	//			this.hotelResultMGM_eField = value;
	//		}
	//	}
	//}

	//// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "WS_2013.Hotel")]
	public partial class HotelResultMGM_e
	{

		private System.DateTime checkInDateField;

		private int numberOfNightsField;

		private int hotelIdField;

		private bool recommendedField;

		private object newGroupsField;

		private object locationNamesField;

		private object recomendationsOrderField;

		private TripAdivisor tripAdivisorField;

		private Rooms roomsField;

		//// <remarks/>
		public System.DateTime CheckInDate
		{
			get
			{
				return this.checkInDateField;
			}
			set
			{
				this.checkInDateField = value;
			}
		}

		//// <remarks/>
		public int NumberOfNights
		{
			get
			{
				return this.numberOfNightsField;
			}
			set
			{
				this.numberOfNightsField = value;
			}
		}

		//// <remarks/>
		public int HotelId
		{
			get
			{
				return this.hotelIdField;
			}
			set
			{
				this.hotelIdField = value;
			}
		}

		//// <remarks/>
		public bool Recommended
		{
			get
			{
				return this.recommendedField;
			}
			set
			{
				this.recommendedField = value;
			}
		}

		//// <remarks/>
		public object NewGroups
		{
			get
			{
				return this.newGroupsField;
			}
			set
			{
				this.newGroupsField = value;
			}
		}

		//// <remarks/>
		public object LocationNames
		{
			get
			{
				return this.locationNamesField;
			}
			set
			{
				this.locationNamesField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
		public object RecomendationsOrder
		{
			get
			{
				return this.recomendationsOrderField;
			}
			set
			{
				this.recomendationsOrderField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "Cangooroo.WS_2013.Hotel")]
		public TripAdivisor TripAdivisor
		{
			get
			{
				return this.tripAdivisorField;
			}
			set
			{
				this.tripAdivisorField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElement(ElementName = "Rooms", Namespace = "Cangooroo.WS_2013.Hotel")]
		public Rooms RoomResultList
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
	}

	//// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "Cangooroo.WS_2013.Hotel")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "Cangooroo.WS_2013.Hotel", IsNullable = false)]
	public partial class TripAdivisor
	{

		private double ratingField;

		private object reviewsField;

		private double numReviewsField;

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public double Rating
		{
			get
			{
				return this.ratingField;
			}
			set
			{
				this.ratingField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public object Reviews
		{
			get
			{
				return this.reviewsField;
			}
			set
			{
				this.reviewsField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public double NumReviews
		{
			get
			{
				return this.numReviewsField;
			}
			set
			{
				this.numReviewsField = value;
			}
		}
	}

	//// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "Cangooroo.WS_2013.Hotel")]
	public partial class RoomResultMGM_e
	{

		private byte qtyAdultsField;

		private object ageOfTheChildrenField;

		private string roomIdField;

		private int hotelIdField;

		private SellPricePerRoom sellPricePerRoomField;

		private SellPriceTotal sellPriceTotalField;

		private string boardDescriptionField;

		private string roomDescriptionField;

		private bool availableField;

		private string hotelCategoryField;

		private bool specialOfferField;

		private byte quantityField;

		private Breakdown[] breakdownSalesField;

		private Commission commissionField;

		private decimal commissionPercentField;

		private object amenitiesField;

		private object roomPicturesField;

		private bool taxesIncludedField;

		private object remarksField;

		private object termsAndConditionsField;

		private bool recommendedRoomField;

		private bool dynamicInventoryField;

		private bool hotelDirectPaymentField;

		private bool breakfastIncludedField;

		private bool isNonRefundableField;

		private bool packageRateField;

		private Comission comissionField;

		private decimal comissionPercentField;

		private bool prePaymentField;

		private object taxesField;

		private string homeTypeField;

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public byte QtyAdults
		{
			get
			{
				return this.qtyAdultsField;
			}
			set
			{
				this.qtyAdultsField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public object AgeOfTheChildren
		{
			get
			{
				return this.ageOfTheChildrenField;
			}
			set
			{
				this.ageOfTheChildrenField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string RoomId
		{
			get
			{
				return this.roomIdField;
			}
			set
			{
				this.roomIdField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public int HotelId
		{
			get
			{
				return this.hotelIdField;
			}
			set
			{
				this.hotelIdField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public SellPricePerRoom SellPricePerRoom
		{
			get
			{
				return this.sellPricePerRoomField;
			}
			set
			{
				this.sellPricePerRoomField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public SellPriceTotal SellPriceTotal
		{
			get
			{
				return this.sellPriceTotalField;
			}
			set
			{
				this.sellPriceTotalField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string BoardDescription
		{
			get
			{
				return this.boardDescriptionField;
			}
			set
			{
				this.boardDescriptionField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string RoomDescription
		{
			get
			{
				return this.roomDescriptionField;
			}
			set
			{
				this.roomDescriptionField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public bool Available
		{
			get
			{
				return this.availableField;
			}
			set
			{
				this.availableField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string HotelCategory
		{
			get
			{
				return this.hotelCategoryField;
			}
			set
			{
				this.hotelCategoryField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public bool SpecialOffer
		{
			get
			{
				return this.specialOfferField;
			}
			set
			{
				this.specialOfferField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public byte Quantity
		{
			get
			{
				return this.quantityField;
			}
			set
			{
				this.quantityField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlArrayAttribute(Namespace = "WS_2013.Hotel")]
		[System.Xml.Serialization.XmlArrayItemAttribute("Breakdown", IsNullable = false)]
		public Breakdown[] BreakdownSales
		{
			get
			{
				return this.breakdownSalesField;
			}
			set
			{
				this.breakdownSalesField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public Commission Commission
		{
			get
			{
				return this.commissionField;
			}
			set
			{
				this.commissionField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public decimal CommissionPercent
		{
			get
			{
				return this.commissionPercentField;
			}
			set
			{
				this.commissionPercentField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public object Amenities
		{
			get
			{
				return this.amenitiesField;
			}
			set
			{
				this.amenitiesField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public object RoomPictures
		{
			get
			{
				return this.roomPicturesField;
			}
			set
			{
				this.roomPicturesField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public bool TaxesIncluded
		{
			get
			{
				return this.taxesIncludedField;
			}
			set
			{
				this.taxesIncludedField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public object Remarks
		{
			get
			{
				return this.remarksField;
			}
			set
			{
				this.remarksField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public object TermsAndConditions
		{
			get
			{
				return this.termsAndConditionsField;
			}
			set
			{
				this.termsAndConditionsField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public bool RecommendedRoom
		{
			get
			{
				return this.recommendedRoomField;
			}
			set
			{
				this.recommendedRoomField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public bool DynamicInventory
		{
			get
			{
				return this.dynamicInventoryField;
			}
			set
			{
				this.dynamicInventoryField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public bool HotelDirectPayment
		{
			get
			{
				return this.hotelDirectPaymentField;
			}
			set
			{
				this.hotelDirectPaymentField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public bool BreakfastIncluded
		{
			get
			{
				return this.breakfastIncludedField;
			}
			set
			{
				this.breakfastIncludedField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public bool IsNonRefundable
		{
			get
			{
				return this.isNonRefundableField;
			}
			set
			{
				this.isNonRefundableField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public bool PackageRate
		{
			get
			{
				return this.packageRateField;
			}
			set
			{
				this.packageRateField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public Comission Comission
		{
			get
			{
				return this.comissionField;
			}
			set
			{
				this.comissionField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public decimal ComissionPercent
		{
			get
			{
				return this.comissionPercentField;
			}
			set
			{
				this.comissionPercentField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public bool PrePayment
		{
			get
			{
				return this.prePaymentField;
			}
			set
			{
				this.prePaymentField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public object Taxes
		{
			get
			{
				return this.taxesField;
			}
			set
			{
				this.taxesField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string HomeType
		{
			get
			{
				return this.homeTypeField;
			}
			set
			{
				this.homeTypeField = value;
			}
		}
	}

	//// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "WS_2013.Hotel")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "WS_2013.Hotel", IsNullable = false)]
	public partial class SellPricePerRoom
	{

		private string currencyField;

		private decimal valueField;

		//// <remarks/>
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

		//// <remarks/>
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

	//// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "WS_2013.Hotel")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "WS_2013.Hotel", IsNullable = false)]
	public partial class SellPriceTotal
	{

		private string currencyField;

		private decimal valueField;

		//// <remarks/>
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

		//// <remarks/>
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

	//// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "WS_2013.Hotel")]
	public partial class Breakdown
	{

		private Price priceField;

		private System.DateTime dateBreakdownField;

		//// <remarks/>
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

		//// <remarks/>
		public System.DateTime DateBreakdown
		{
			get
			{
				return this.dateBreakdownField;
			}
			set
			{
				this.dateBreakdownField = value;
			}
		}
	}

	//// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "WS_2013.Hotel")]
	public partial class Price
	{

		private string currencyField;

		private decimal valueField;

		//// <remarks/>
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

		//// <remarks/>
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

	//// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "WS_2013.Hotel")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "WS_2013.Hotel", IsNullable = false)]
	public partial class Commission
	{

		private string currencyField;

		private decimal valueField;

		//// <remarks/>
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

		//// <remarks/>
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

	//// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "WS_2013.Hotel")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "WS_2013.Hotel", IsNullable = false)]
	public partial class Comission
	{

		private string currencyField;

		private decimal valueField;

		//// <remarks/>
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

		//// <remarks/>
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

	//---------------------------------// GetCancellationPoliciesRQ //---------------------------------------------//

	//// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ws_2013.services.cangooroo.net/")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://ws_2013.services.cangooroo.net/", IsNullable = false)]
	public partial class getCancellationPolicies
	{

		private Credential credentialField;

		private RequestCancellationPolicies requestCancellationPoliciesField;

		//// <remarks/>
		public Credential credential
		{
			get
			{
				return this.credentialField;
			}
			set
			{
				this.credentialField = value;
			}
		}

		//// <remarks/>
		public RequestCancellationPolicies requestCancellationPolicies
		{
			get
			{
				return this.requestCancellationPoliciesField;
			}
			set
			{
				this.requestCancellationPoliciesField = value;
			}
		}
	}

	//// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ws_2013.services.cangooroo.net/")]
	public partial class RequestCancellationPolicies
	{

		private string tokenField;

		private int hotelIdField;

		private RoomsIds roomsIdsField;

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string Token
		{
			get
			{
				return this.tokenField;
			}
			set
			{
				this.tokenField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public int HotelId
		{
			get
			{
				return this.hotelIdField;
			}
			set
			{
				this.hotelIdField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public RoomsIds RoomsIds
		{
			get
			{
				return this.roomsIdsField;
			}
			set
			{
				this.roomsIdsField = value;
			}
		}
	}

	//// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "WS_2013.Hotel")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "WS_2013.Hotel", IsNullable = false)]
	public partial class RoomsIds
	{

		private string stringField;

		//// <remarks/>
		public string @string
		{
			get
			{
				return this.stringField;
			}
			set
			{
				this.stringField = value;
			}
		}
	}

	//---------------------------------// GetCancellationPoliciesRS //---------------------------------------------//

	//// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ws_2013.services.cangooroo.net/")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://ws_2013.services.cangooroo.net/", IsNullable = false)]
	public partial class getCancellationPoliciesResponse
	{

		private GetCancellationPoliciesResult getCancellationPoliciesResultField;

		//// <remarks/>
		public GetCancellationPoliciesResult getCancellationPoliciesResult
		{
			get
			{
				return this.getCancellationPoliciesResultField;
			}
			set
			{
				this.getCancellationPoliciesResultField = value;
			}
		}
	}

	//// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ws_2013.services.cangooroo.net/")]
	public partial class GetCancellationPoliciesResult
	{

		private string tokenField;

		private SelectedHotel selectedHotelField;

		private string statusCancellationPolicyField;

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string Token
		{
			get
			{
				return this.tokenField;
			}
			set
			{
				this.tokenField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public SelectedHotel SelectedHotel
		{
			get
			{
				return this.selectedHotelField;
			}
			set
			{
				this.selectedHotelField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string StatusCancellationPolicy
		{
			get
			{
				return this.statusCancellationPolicyField;
			}
			set
			{
				this.statusCancellationPolicyField = value;
			}
		}
	}

	//// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "WS_2013.Hotel")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "WS_2013.Hotel", IsNullable = false)]
	public partial class SelectedHotel
	{

		private System.DateTime checkInDateField;

		private int numberOfNightsField;

		private int hotelIdField;

		private bool recommendedField;

		private HotelInfo hotelInfoField;

		private object recomendationsOrderField;

		private Rooms roomsField;

		//// <remarks/>
		public System.DateTime CheckInDate
		{
			get
			{
				return this.checkInDateField;
			}
			set
			{
				this.checkInDateField = value;
			}
		}

		//// <remarks/>
		public int NumberOfNights
		{
			get
			{
				return this.numberOfNightsField;
			}
			set
			{
				this.numberOfNightsField = value;
			}
		}

		//// <remarks/>
		public int HotelId
		{
			get
			{
				return this.hotelIdField;
			}
			set
			{
				this.hotelIdField = value;
			}
		}

		//// <remarks/>
		public bool Recommended
		{
			get
			{
				return this.recommendedField;
			}
			set
			{
				this.recommendedField = value;
			}
		}

		//// <remarks/>
		public HotelInfo HotelInfo
		{
			get
			{
				return this.hotelInfoField;
			}
			set
			{
				this.hotelInfoField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
		public object RecomendationsOrder
		{
			get
			{
				return this.recomendationsOrderField;
			}
			set
			{
				this.recomendationsOrderField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElement(Namespace = "Cangooroo.WS_2013.Hotel")]
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
	}

	//// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "WS_2013.Hotel")]
	public partial class HotelInfo
	{

		private int cityIdField;

		private string hotelNameField;

		private string addressField;

		private string hotelCategoryField;

		private int hotelIdField;

		private object lastUpdateField;

		//// <remarks/>
		public int CityId
		{
			get
			{
				return this.cityIdField;
			}
			set
			{
				this.cityIdField = value;
			}
		}

		//// <remarks/>
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

		//// <remarks/>
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

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
		public string HotelCategory
		{
			get
			{
				return this.hotelCategoryField;
			}
			set
			{
				this.hotelCategoryField = value;
			}
		}

		//// <remarks/>
		public int HotelId
		{
			get
			{
				return this.hotelIdField;
			}
			set
			{
				this.hotelIdField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
		public object LastUpdate
		{
			get
			{
				return this.lastUpdateField;
			}
			set
			{
				this.lastUpdateField = value;
			}
		}
	}

	//// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "Cangooroo.WS_2013.Hotel")]
	public partial class RoomResultCancellationPolicies_b
	{

		private byte qtyAdultsField;

		private object ageOfTheChildrenField;

		private string roomIdField;

		private int hotelIdField;

		private SellPricePerRoom sellPricePerRoomField;

		private SellPriceTotal sellPriceTotalField;

		private string boardDescriptionField;

		private string roomDescriptionField;

		private bool availableField;

		private string hotelCategoryField;

		private bool specialOfferField;

		private byte quantityField;

		private Breakdown[] breakdownSalesField;

		private Commission commissionField;

		private decimal commissionPercentField;

		private object amenitiesField;

		private object roomPicturesField;

		private bool taxesIncludedField;

		private object remarksField;

		private object termsAndConditionsField;

		private bool recommendedRoomField;

		private bool dynamicInventoryField;

		private OperatorCancellationPolicies operatorCancellationPoliciesField;

		private bool hotelDirectPaymentField;

		private bool breakfastIncludedField;

		private bool isNonRefundableField;

		private bool packageRateField;

		private decimal comissionPercentField;

		private object invoiceItensField;

		private bool prePaymentField;

		private object taxesField;

		private string homeTypeField;

		private OldSellPriceTotal oldSellPriceTotalField;

		private bool newPriceIsGreaterThanOldPriceField;

		private bool bookableField;

		private string guaranteeTypeField;

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public byte QtyAdults
		{
			get
			{
				return this.qtyAdultsField;
			}
			set
			{
				this.qtyAdultsField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public object AgeOfTheChildren
		{
			get
			{
				return this.ageOfTheChildrenField;
			}
			set
			{
				this.ageOfTheChildrenField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string RoomId
		{
			get
			{
				return this.roomIdField;
			}
			set
			{
				this.roomIdField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public int HotelId
		{
			get
			{
				return this.hotelIdField;
			}
			set
			{
				this.hotelIdField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public SellPricePerRoom SellPricePerRoom
		{
			get
			{
				return this.sellPricePerRoomField;
			}
			set
			{
				this.sellPricePerRoomField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public SellPriceTotal SellPriceTotal
		{
			get
			{
				return this.sellPriceTotalField;
			}
			set
			{
				this.sellPriceTotalField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string BoardDescription
		{
			get
			{
				return this.boardDescriptionField;
			}
			set
			{
				this.boardDescriptionField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string RoomDescription
		{
			get
			{
				return this.roomDescriptionField;
			}
			set
			{
				this.roomDescriptionField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public bool Available
		{
			get
			{
				return this.availableField;
			}
			set
			{
				this.availableField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string HotelCategory
		{
			get
			{
				return this.hotelCategoryField;
			}
			set
			{
				this.hotelCategoryField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public bool SpecialOffer
		{
			get
			{
				return this.specialOfferField;
			}
			set
			{
				this.specialOfferField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public byte Quantity
		{
			get
			{
				return this.quantityField;
			}
			set
			{
				this.quantityField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlArrayAttribute(Namespace = "WS_2013.Hotel")]
		[System.Xml.Serialization.XmlArrayItemAttribute("Breakdown", IsNullable = false)]
		public Breakdown[] BreakdownSales
		{
			get
			{
				return this.breakdownSalesField;
			}
			set
			{
				this.breakdownSalesField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public Commission Commission
		{
			get
			{
				return this.commissionField;
			}
			set
			{
				this.commissionField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public decimal CommissionPercent
		{
			get
			{
				return this.commissionPercentField;
			}
			set
			{
				this.commissionPercentField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public object Amenities
		{
			get
			{
				return this.amenitiesField;
			}
			set
			{
				this.amenitiesField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public object RoomPictures
		{
			get
			{
				return this.roomPicturesField;
			}
			set
			{
				this.roomPicturesField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public bool TaxesIncluded
		{
			get
			{
				return this.taxesIncludedField;
			}
			set
			{
				this.taxesIncludedField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public object Remarks
		{
			get
			{
				return this.remarksField;
			}
			set
			{
				this.remarksField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public object TermsAndConditions
		{
			get
			{
				return this.termsAndConditionsField;
			}
			set
			{
				this.termsAndConditionsField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public bool RecommendedRoom
		{
			get
			{
				return this.recommendedRoomField;
			}
			set
			{
				this.recommendedRoomField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public bool DynamicInventory
		{
			get
			{
				return this.dynamicInventoryField;
			}
			set
			{
				this.dynamicInventoryField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public OperatorCancellationPolicies OperatorCancellationPolicies
		{
			get
			{
				return this.operatorCancellationPoliciesField;
			}
			set
			{
				this.operatorCancellationPoliciesField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public bool HotelDirectPayment
		{
			get
			{
				return this.hotelDirectPaymentField;
			}
			set
			{
				this.hotelDirectPaymentField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public bool BreakfastIncluded
		{
			get
			{
				return this.breakfastIncludedField;
			}
			set
			{
				this.breakfastIncludedField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public bool IsNonRefundable
		{
			get
			{
				return this.isNonRefundableField;
			}
			set
			{
				this.isNonRefundableField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public bool PackageRate
		{
			get
			{
				return this.packageRateField;
			}
			set
			{
				this.packageRateField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public decimal ComissionPercent
		{
			get
			{
				return this.comissionPercentField;
			}
			set
			{
				this.comissionPercentField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public object InvoiceItens
		{
			get
			{
				return this.invoiceItensField;
			}
			set
			{
				this.invoiceItensField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public bool PrePayment
		{
			get
			{
				return this.prePaymentField;
			}
			set
			{
				this.prePaymentField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public object Taxes
		{
			get
			{
				return this.taxesField;
			}
			set
			{
				this.taxesField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string HomeType
		{
			get
			{
				return this.homeTypeField;
			}
			set
			{
				this.homeTypeField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "Cangooroo.Webservice.V2.Hotel")]
		public OldSellPriceTotal OldSellPriceTotal
		{
			get
			{
				return this.oldSellPriceTotalField;
			}
			set
			{
				this.oldSellPriceTotalField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "Cangooroo.Webservice.V2.Hotel")]
		public bool NewPriceIsGreaterThanOldPrice
		{
			get
			{
				return this.newPriceIsGreaterThanOldPriceField;
			}
			set
			{
				this.newPriceIsGreaterThanOldPriceField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "Cangooroo.Webservice.V2.Hotel")]
		public bool Bookable
		{
			get
			{
				return this.bookableField;
			}
			set
			{
				this.bookableField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "Cangooroo.Webservice.V2.Hotel")]
		public string GuaranteeType
		{
			get
			{
				return this.guaranteeTypeField;
			}
			set
			{
				this.guaranteeTypeField = value;
			}
		}
	}

	//// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "WS_2013.Hotel")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "WS_2013.Hotel", IsNullable = false)]
	public partial class OperatorCancellationPolicies
	{

		private CancellationPolicy cancellationPolicyField;

		//// <remarks/>
		public CancellationPolicy CancellationPolicy
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

	//// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "WS_2013.Hotel")]
	public partial class CancellationPolicy
	{

		private System.DateTime startDateField;

		private System.DateTime endDateField;

		private Price priceField;

		//// <remarks/>
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

		//// <remarks/>
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

		//// <remarks/>
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

	//// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "Cangooroo.Webservice.V2.Hotel")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "Cangooroo.Webservice.V2.Hotel", IsNullable = false)]
	public partial class OldSellPriceTotal
	{

		private string currencyField;

		private decimal valueField;

		//// <remarks/>
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

		//// <remarks/>
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

	//---------------------------------// DoBookingRQ //---------------------------------------------//

	//// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ws_2013.services.cangooroo.net/")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://ws_2013.services.cangooroo.net/", IsNullable = false)]
	public partial class doBooking
	{

		private Credential credentialField;

		private HotelBooking hotelBookingField;

		//// <remarks/>
		public Credential credential
		{
			get
			{
				return this.credentialField;
			}
			set
			{
				this.credentialField = value;
			}
		}

		/// <remarks/>
		public HotelBooking hotelBooking
		{
			get
			{
				return this.hotelBookingField;
			}
			set
			{
				this.hotelBookingField = value;
			}
		}
	}

	//// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ws_2013.services.cangooroo.net/")]
	public partial class HotelBooking
	{

		private string tokenField;

		private Rooms roomsField;

		private string bookingIdField;

		private object clientReferenceField;

		private object clientObservationField;

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string Token
		{
			get
			{
				return this.tokenField;
			}
			set
			{
				this.tokenField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElement(Namespace = "WS_2013.Hotel", ElementName = "Rooms")]
		public Rooms RoomBookingList
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

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string BookingId
		{
			get
			{
				return this.bookingIdField;
			}
			set
			{
				this.bookingIdField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public object ClientReference
		{
			get
			{
				return this.clientReferenceField;
			}
			set
			{
				this.clientReferenceField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public object ClientObservation
		{
			get
			{
				return this.clientObservationField;
			}
			set
			{
				this.clientObservationField = value;
			}
		}
	}

	//// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "WS_2013.Hotel")]
	public partial class RoomBooking_b
	{

		private int hotelIdField;

		private string roomIdField;

		private Pax[] paxsField;

		//// <remarks/>
		public int HotelId
		{
			get
			{
				return this.hotelIdField;
			}
			set
			{
				this.hotelIdField = value;
			}
		}

		//// <remarks/>
		public string RoomId
		{
			get
			{
				return this.roomIdField;
			}
			set
			{
				this.roomIdField = value;
			}
		}

		//// <remarks/>
		public Pax[] Paxs
		{
			get
			{
				return this.paxsField;
			}
			set
			{
				this.paxsField = value;
			}
		}
	}

	//// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "WS_2013.Hotel")]
	public partial class Pax
	{
		private string nameField;

		private string lastNameField;

		private int ageField;

		private string enumTitleField;

		private string enumPaxTypeField;

		//// <remarks/>
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

		//// <remarks/>
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

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Common")]
		public int Age
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

		//// <remarks/>
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

		//// <remarks/>
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

	//---------------------------------// DoBookingRS //---------------------------------------------//


	//// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ws_2013.services.cangooroo.net/")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://ws_2013.services.cangooroo.net/", IsNullable = false)]
	public partial class doBookingResponse
	{

		private DoBookingResult doBookingResultField;

		//// <remarks/>
		public DoBookingResult doBookingResult
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

	//// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ws_2013.services.cangooroo.net/")]
	public partial class DoBookingResult
	{

		private ushort bookingNumberField;

		private string clientIDField;

		private string clientNameField;

		private string operatorNameField;

		private byte numberOfBookingRoomsField;

		private byte baseIDField;

		private byte cNPJField;

		//private Rooms roomsField;

		private object transfersField;

		private object toursField;

		private object carsField;

		private object trainTicketsField;

		private object trainPassField;

		private object insurancesField;

		private object travelPackagesField;

		private object circuitoField;

		private object flightsField;

		// <remarks/>
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

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "Cangooroo.WS_2013")]
		public string ClientID
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

		// <remarks/>
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

		// <remarks/>
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

		// <remarks/>
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

		// <remarks/>
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

		// <remarks/>
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

		// <remarks/>
		[System.Xml.Serialization.XmlElement(Namespace = "Cangooroo.WS_2013", ElementName = "Rooms")]
		public Rooms HotelBookingRoomResult_d { get; set; }

		// <remarks/>
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

		// <remarks/>
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

		// <remarks/>
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

		// <remarks/>
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

		// <remarks/>
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

		// <remarks/>
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

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "Cangooroo.WS_2013")]
		public object TravelPackages
		{
			get
			{
				return this.travelPackagesField;
			}
			set
			{
				this.travelPackagesField = value;
			}
		}

		// <remarks/>
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

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "Cangooroo.WS_2013")]
		public object Flights
		{
			get
			{
				return this.flightsField;
			}
			set
			{
				this.flightsField = value;
			}
		}
	}

	// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "Cangooroo.WS_2013")]
	public partial class HotelBookingRoomResult_d
	{

		private bool cancelationBlockWSField;

		private string boardDescriptionField;

		private bool breakfastIncludedField;

		private string hotelCategoryField;

		private int cityIdField;

		private decimal agencyCommissionField;

		private System.DateTime cancellationDateField;

		private System.DateTime checkInDateField;

		private System.DateTime paymentDeadlineField;

		private System.DateTime reservationDateField;

		private string hotelAddressField;

		private int hotelIdField;

		private string serviceIdField;

		private string logXMLAuditIdField;

		private string agencyCurrencyCommissionField;

		private string cityNameField;

		private string hotelNameField;

		private byte numberOfAdultsField;

		private byte numberOfChildrenField;

		private int numberOfNightsField;

		private string voucherObservationField;

		private string countryIdField;

		private Pax[] paxsField;

		private NetPrice netPriceField;

		private OperatorCancellationPolicies operatorCancellationPoliciesField;

		private string reservationIdField;

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

		//private object taxesField;

		private object roomClientReferenceField;

		private string urlVoucherField;

		private object hotelCNPJField;

		//private byte paymentConvertionRateField;

		//private string paymentCurrencyField;

		private string bookingDescriptionField;

		private string observationField;
		private string locationField;


		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string BookingDescription
		{
			get
			{
				return this.bookingDescriptionField;
			}
			set
			{
				this.bookingDescriptionField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string Observation
		{
			get
			{
				return this.observationField;
			}
			set
			{
				this.observationField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public bool CancelationBlockWS
		{
			get
			{
				return this.cancelationBlockWSField;
			}
			set
			{
				this.cancelationBlockWSField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string BoardDescription
		{
			get
			{
				return this.boardDescriptionField;
			}
			set
			{
				this.boardDescriptionField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public bool BreakfastIncluded
		{
			get
			{
				return this.breakfastIncludedField;
			}
			set
			{
				this.breakfastIncludedField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string HotelCategory
		{
			get
			{
				return this.hotelCategoryField;
			}
			set
			{
				this.hotelCategoryField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public int CityId
		{
			get
			{
				return this.cityIdField;
			}
			set
			{
				this.cityIdField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public decimal AgencyCommission
		{
			get
			{
				return this.agencyCommissionField;
			}
			set
			{
				this.agencyCommissionField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public System.DateTime CancellationDate
		{
			get
			{
				return this.cancellationDateField;
			}
			set
			{
				this.cancellationDateField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public System.DateTime CheckInDate
		{
			get
			{
				return this.checkInDateField;
			}
			set
			{
				this.checkInDateField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public System.DateTime PaymentDeadline
		{
			get
			{
				return this.paymentDeadlineField;
			}
			set
			{
				this.paymentDeadlineField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public System.DateTime ReservationDate
		{
			get
			{
				return this.reservationDateField;
			}
			set
			{
				this.reservationDateField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string HotelAddress
		{
			get
			{
				return this.hotelAddressField;
			}
			set
			{
				this.hotelAddressField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public int HotelId
		{
			get
			{
				return this.hotelIdField;
			}
			set
			{
				this.hotelIdField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string ServiceId
		{
			get
			{
				return this.serviceIdField;
			}
			set
			{
				this.serviceIdField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string Location
		{
			get
			{
				return this.locationField;
			}
			set
			{
				this.locationField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string LogXMLAuditId
		{
			get
			{
				return this.logXMLAuditIdField;
			}
			set
			{
				this.logXMLAuditIdField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string AgencyCurrencyCommission
		{
			get
			{
				return this.agencyCurrencyCommissionField;
			}
			set
			{
				this.agencyCurrencyCommissionField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string CityName
		{
			get
			{
				return this.cityNameField;
			}
			set
			{
				this.cityNameField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
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

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public byte NumberOfAdults
		{
			get
			{
				return this.numberOfAdultsField;
			}
			set
			{
				this.numberOfAdultsField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public byte NumberOfChildren
		{
			get
			{
				return this.numberOfChildrenField;
			}
			set
			{
				this.numberOfChildrenField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public int NumberOfNights
		{
			get
			{
				return this.numberOfNightsField;
			}
			set
			{
				this.numberOfNightsField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string VoucherObservation
		{
			get
			{
				return this.voucherObservationField;
			}
			set
			{
				this.voucherObservationField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string CountryId
		{
			get
			{
				return this.countryIdField;
			}
			set
			{
				this.countryIdField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public Pax[] Paxs
		{
			get
			{
				return this.paxsField;
			}
			set
			{
				this.paxsField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public NetPrice NetPrice
		{
			get
			{
				return this.netPriceField;
			}
			set
			{
				this.netPriceField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public OperatorCancellationPolicies OperatorCancellationPolicies
		{
			get
			{
				return this.operatorCancellationPoliciesField;
			}
			set
			{
				this.operatorCancellationPoliciesField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string ReservationId
		{
			get
			{
				return this.reservationIdField;
			}
			set
			{
				this.reservationIdField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string RoomDescription
		{
			get
			{
				return this.roomDescriptionField;
			}
			set
			{
				this.roomDescriptionField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string PaymentStatus
		{
			get
			{
				return this.paymentStatusField;
			}
			set
			{
				this.paymentStatusField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string SystemStatus
		{
			get
			{
				return this.systemStatusField;
			}
			set
			{
				this.systemStatusField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public byte ConversionRate
		{
			get
			{
				return this.conversionRateField;
			}
			set
			{
				this.conversionRateField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string HotelPhone
		{
			get
			{
				return this.hotelPhoneField;
			}
			set
			{
				this.hotelPhoneField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string ProviderID
		{
			get
			{
				return this.providerIDField;
			}
			set
			{
				this.providerIDField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string ProviderName
		{
			get
			{
				return this.providerNameField;
			}
			set
			{
				this.providerNameField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string ProviderLogo
		{
			get
			{
				return this.providerLogoField;
			}
			set
			{
				this.providerLogoField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string ProviderBookingCode
		{
			get
			{
				return this.providerBookingCodeField;
			}
			set
			{
				this.providerBookingCodeField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public System.DateTime PaymentDate
		{
			get
			{
				return this.paymentDateField;
			}
			set
			{
				this.paymentDateField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string PaymentType
		{
			get
			{
				return this.paymentTypeField;
			}
			set
			{
				this.paymentTypeField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public object Remarks
		{
			get
			{
				return this.remarksField;
			}
			set
			{
				this.remarksField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public CreationUserDetail CreationUserDetail
		{
			get
			{
				return this.creationUserDetailField;
			}
			set
			{
				this.creationUserDetailField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public LastUpdateUserDetail LastUpdateUserDetail
		{
			get
			{
				return this.lastUpdateUserDetailField;
			}
			set
			{
				this.lastUpdateUserDetailField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public object Payments
		{
			get
			{
				return this.paymentsField;
			}
			set
			{
				this.paymentsField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string UrlVoucher
		{
			get
			{
				return this.urlVoucherField;
			}
			set
			{
				this.urlVoucherField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public object HotelCNPJ
		{
			get
			{
				return this.hotelCNPJField;
			}
			set
			{
				this.hotelCNPJField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public object RoomClientReference
		{
			get
			{
				return this.roomClientReferenceField;
			}
			set
			{
				this.roomClientReferenceField = value;
			}
		}
	}

	//// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "WS_2013.Hotel")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "WS_2013.Hotel", IsNullable = false)]
	public partial class NetPrice
	{

		private string currencyField;

		private decimal valueField;

		//// <remarks/>
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

		//// <remarks/>
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

	//// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "WS_2013.Hotel")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "WS_2013.Hotel", IsNullable = false)]
	public partial class CreationUserDetail
	{

		private string nameField;

		private uint idField;

		private string userNameField;

		private string emailField;

		//// <remarks/>
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

		//// <remarks/>
		public uint Id
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

		//// <remarks/>
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

		//// <remarks/>
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

	//// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "WS_2013.Hotel")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "WS_2013.Hotel", IsNullable = false)]
	public partial class LastUpdateUserDetail
	{

		private string nameField;

		private uint idField;

		private string userNameField;

		private string emailField;

		//// <remarks/>
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

		//// <remarks/>
		public uint Id
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

		//// <remarks/>
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

		//// <remarks/>
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

	//---------------------------------// CancelRQ //---------------------------------------------//

	//// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ws_2013.services.cangooroo.net/")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://ws_2013.services.cangooroo.net/", IsNullable = false)]
	public partial class cancelBooking
	{

		private Credential credentialField;

		private string serviceIDField;

		//// <remarks/>
		public Credential credential
		{
			get
			{
				return this.credentialField;
			}
			set
			{
				this.credentialField = value;
			}
		}

		//// <remarks/>
		public string serviceID
		{
			get
			{
				return this.serviceIDField;
			}
			set
			{
				this.serviceIDField = value;
			}
		}
	}

	//---------------------------------// CancelRS //---------------------------------------------//

	//// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ws_2013.services.cangooroo.net/")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://ws_2013.services.cangooroo.net/", IsNullable = false)]
	public partial class cancelBookingResponse
	{

		private CancelBookingResult cancelBookingResultField;

		//// <remarks/>
		public CancelBookingResult cancelBookingResult
		{
			get
			{
				return this.cancelBookingResultField;
			}
			set
			{
				this.cancelBookingResultField = value;
			}
		}
	}

	//// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ws_2013.services.cangooroo.net/")]
	public partial class CancelBookingResult
	{

		private bool cancelationBlockWSField;

		private string boardDescriptionField;

		private bool breakfastIncludedField;

		private string hotelCategoryField;

		private int cityIdField;

		private decimal agencyCommissionField;

		private System.DateTime cancellationDateField;

		private System.DateTime checkInDateField;

		private System.DateTime paymentDeadlineField;

		private System.DateTime reservationDateField;

		private string hotelAddressField;

		private int hotelIdField;

		private string serviceIdField;

		private string logXMLAuditIdField;

		private string agencyCurrencyCommissionField;

		private string cityNameField;

		private string hotelNameField;

		private byte numberOfAdultsField;

		private byte numberOfChildrenField;

		private int numberOfNightsField;

		private string voucherObservationField;

		private string countryIdField;

		private Pax[] paxsField;

		private NetPrice netPriceField;

		private OperatorCancellationPolicies operatorCancellationPoliciesField;

		private string reservationIdField;

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

		private object taxesField;

		private object roomClientReferenceField;

		private string urlVoucherField;

		private object hotelCNPJField;

		private decimal paymentConvertionRateField;

		private string paymentCurrencyField;

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public bool CancelationBlockWS
		{
			get
			{
				return this.cancelationBlockWSField;
			}
			set
			{
				this.cancelationBlockWSField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string BoardDescription
		{
			get
			{
				return this.boardDescriptionField;
			}
			set
			{
				this.boardDescriptionField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public bool BreakfastIncluded
		{
			get
			{
				return this.breakfastIncludedField;
			}
			set
			{
				this.breakfastIncludedField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string HotelCategory
		{
			get
			{
				return this.hotelCategoryField;
			}
			set
			{
				this.hotelCategoryField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public int CityId
		{
			get
			{
				return this.cityIdField;
			}
			set
			{
				this.cityIdField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public decimal AgencyCommission
		{
			get
			{
				return this.agencyCommissionField;
			}
			set
			{
				this.agencyCommissionField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public System.DateTime CancellationDate
		{
			get
			{
				return this.cancellationDateField;
			}
			set
			{
				this.cancellationDateField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public System.DateTime CheckInDate
		{
			get
			{
				return this.checkInDateField;
			}
			set
			{
				this.checkInDateField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public System.DateTime PaymentDeadline
		{
			get
			{
				return this.paymentDeadlineField;
			}
			set
			{
				this.paymentDeadlineField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public System.DateTime ReservationDate
		{
			get
			{
				return this.reservationDateField;
			}
			set
			{
				this.reservationDateField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string HotelAddress
		{
			get
			{
				return this.hotelAddressField;
			}
			set
			{
				this.hotelAddressField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public int HotelId
		{
			get
			{
				return this.hotelIdField;
			}
			set
			{
				this.hotelIdField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string ServiceId
		{
			get
			{
				return this.serviceIdField;
			}
			set
			{
				this.serviceIdField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string LogXMLAuditId
		{
			get
			{
				return this.logXMLAuditIdField;
			}
			set
			{
				this.logXMLAuditIdField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string AgencyCurrencyCommission
		{
			get
			{
				return this.agencyCurrencyCommissionField;
			}
			set
			{
				this.agencyCurrencyCommissionField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string CityName
		{
			get
			{
				return this.cityNameField;
			}
			set
			{
				this.cityNameField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
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

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public byte NumberOfAdults
		{
			get
			{
				return this.numberOfAdultsField;
			}
			set
			{
				this.numberOfAdultsField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public byte NumberOfChildren
		{
			get
			{
				return this.numberOfChildrenField;
			}
			set
			{
				this.numberOfChildrenField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public int NumberOfNights
		{
			get
			{
				return this.numberOfNightsField;
			}
			set
			{
				this.numberOfNightsField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string VoucherObservation
		{
			get
			{
				return this.voucherObservationField;
			}
			set
			{
				this.voucherObservationField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string CountryId
		{
			get
			{
				return this.countryIdField;
			}
			set
			{
				this.countryIdField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public Pax[] Paxs
		{
			get
			{
				return this.paxsField;
			}
			set
			{
				this.paxsField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public NetPrice NetPrice
		{
			get
			{
				return this.netPriceField;
			}
			set
			{
				this.netPriceField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public OperatorCancellationPolicies OperatorCancellationPolicies
		{
			get
			{
				return this.operatorCancellationPoliciesField;
			}
			set
			{
				this.operatorCancellationPoliciesField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string ReservationId
		{
			get
			{
				return this.reservationIdField;
			}
			set
			{
				this.reservationIdField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string RoomDescription
		{
			get
			{
				return this.roomDescriptionField;
			}
			set
			{
				this.roomDescriptionField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string PaymentStatus
		{
			get
			{
				return this.paymentStatusField;
			}
			set
			{
				this.paymentStatusField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string SystemStatus
		{
			get
			{
				return this.systemStatusField;
			}
			set
			{
				this.systemStatusField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public byte ConversionRate
		{
			get
			{
				return this.conversionRateField;
			}
			set
			{
				this.conversionRateField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string HotelPhone
		{
			get
			{
				return this.hotelPhoneField;
			}
			set
			{
				this.hotelPhoneField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string ProviderID
		{
			get
			{
				return this.providerIDField;
			}
			set
			{
				this.providerIDField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string ProviderName
		{
			get
			{
				return this.providerNameField;
			}
			set
			{
				this.providerNameField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string ProviderLogo
		{
			get
			{
				return this.providerLogoField;
			}
			set
			{
				this.providerLogoField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string ProviderBookingCode
		{
			get
			{
				return this.providerBookingCodeField;
			}
			set
			{
				this.providerBookingCodeField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public System.DateTime PaymentDate
		{
			get
			{
				return this.paymentDateField;
			}
			set
			{
				this.paymentDateField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string PaymentType
		{
			get
			{
				return this.paymentTypeField;
			}
			set
			{
				this.paymentTypeField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public object Remarks
		{
			get
			{
				return this.remarksField;
			}
			set
			{
				this.remarksField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public CreationUserDetail CreationUserDetail
		{
			get
			{
				return this.creationUserDetailField;
			}
			set
			{
				this.creationUserDetailField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public LastUpdateUserDetail LastUpdateUserDetail
		{
			get
			{
				return this.lastUpdateUserDetailField;
			}
			set
			{
				this.lastUpdateUserDetailField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public object Payments
		{
			get
			{
				return this.paymentsField;
			}
			set
			{
				this.paymentsField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public object Taxes
		{
			get
			{
				return this.taxesField;
			}
			set
			{
				this.taxesField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public object RoomClientReference
		{
			get
			{
				return this.roomClientReferenceField;
			}
			set
			{
				this.roomClientReferenceField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string UrlVoucher
		{
			get
			{
				return this.urlVoucherField;
			}
			set
			{
				this.urlVoucherField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public object HotelCNPJ
		{
			get
			{
				return this.hotelCNPJField;
			}
			set
			{
				this.hotelCNPJField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public decimal PaymentConvertionRate
		{
			get
			{
				return this.paymentConvertionRateField;
			}
			set
			{
				this.paymentConvertionRateField = value;
			}
		}

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string PaymentCurrency
		{
			get
			{
				return this.paymentCurrencyField;
			}
			set
			{
				this.paymentCurrencyField = value;
			}
		}
	}

	//--------------------------------// GetBooking //---------------------------------------------//

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/", IsNullable = false)]
	public partial class getBookingDetail
	{

		private getBookingDetailCredential credentialField;

		private string bookingIdField;

		/// <remarks/>
		public getBookingDetailCredential credential
		{
			get
			{
				return this.credentialField;
			}
			set
			{
				this.credentialField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://tempuri.org/")]
		public string bookingId
		{
			get
			{
				return this.bookingIdField;
			}
			set
			{
				this.bookingIdField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/")]
	public partial class getBookingDetailCredential
	{

		private string userNameField;

		private string passwordField;

		private string clientIdField;

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.ClientCredential")]
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

		//// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.ClientCredential")]
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
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.ClientCredential")]
		public string ClientId
		{
			get
			{
				return this.clientIdField;
			}
			set
			{
				this.clientIdField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/", IsNullable = false)]
	public partial class getBookingDetailResponse
	{

		private getBookingDetailResult getBookingDetailResultField;

		/// <remarks/>
		public getBookingDetailResult getBookingDetailResult
		{
			get
			{
				return this.getBookingDetailResultField;
			}
			set
			{
				this.getBookingDetailResultField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/")]
	public partial class getBookingDetailResult
	{

		private ushort bookingNumberField;

		private string clientIDField;

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

		private object travelPackagesField;

		private object circuitoField;

		private object flightsField;

		private System.DateTime lastUpdateField;

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
		public string ClientID
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

		//// <remarks/>
		[System.Xml.Serialization.XmlElement(ElementName = "Rooms", Namespace = "Cangooroo.WS_2013")]
		public Rooms RoomResultList
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
		public object TravelPackages
		{
			get
			{
				return this.travelPackagesField;
			}
			set
			{
				this.travelPackagesField = value;
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

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "Cangooroo.WS_2013")]
		public object Flights
		{
			get
			{
				return this.flightsField;
			}
			set
			{
				this.flightsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "Cangooroo.WS_2013")]
		public System.DateTime LastUpdate
		{
			get
			{
				return this.lastUpdateField;
			}
			set
			{
				this.lastUpdateField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "Cangooroo.WS_2013")]
	public partial class HotelBookingRoomResult_j
	{

		private string bookingDescriptionField;

		private bool cancelationBlockWSField;

		private string boardDescriptionField;

		private bool breakfastIncludedField;

		private string hotelCategoryField;

		private int cityIdField;

		private decimal agencyCommissionField;

		private System.DateTime cancellationDateField;

		private System.DateTime checkInDateField;

		private System.DateTime paymentDeadlineField;

		private System.DateTime reservationDateField;

		private string hotelAddressField;

		private int hotelIdField;

		private string serviceIdField;

		private string locationField;

		private string logXMLAuditIdField;

		private string agencyCurrencyCommissionField;

		private string cityNameField;

		private string hotelNameField;

		private byte numberOfAdultsField;

		private byte numberOfChildrenField;

		private int numberOfNightsField;

		private string observationField;

		private string voucherObservationField;

		private string countryIdField;

		private Pax[] paxsField;

		private NetPrice netPriceField;

		private OperatorCancellationPolicies operatorCancellationPoliciesField;

		private string reservationIdField;

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

		private object taxesField;

		private string invoiceItemsField;

		private bool billedField;

		private Breakdown[] breakdownSalesField;

		private string typeField;

		private string acceptPaymentField;

		private string cancellationTypeField;

		private object supplierExternalReservationCodeField;

		private object roomClientReferenceField;

		private string urlVoucherField;

		private object hotelCNPJField;

		private decimal paymentConvertionRateField;

		private string paymentCurrencyField;

		private System.DateTime lastUpdateField;

		private bool canSeeVoucherField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string BookingDescription
		{
			get
			{
				return this.bookingDescriptionField;
			}
			set
			{
				this.bookingDescriptionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public bool CancelationBlockWS
		{
			get
			{
				return this.cancelationBlockWSField;
			}
			set
			{
				this.cancelationBlockWSField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string BoardDescription
		{
			get
			{
				return this.boardDescriptionField;
			}
			set
			{
				this.boardDescriptionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public bool BreakfastIncluded
		{
			get
			{
				return this.breakfastIncludedField;
			}
			set
			{
				this.breakfastIncludedField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string HotelCategory
		{
			get
			{
				return this.hotelCategoryField;
			}
			set
			{
				this.hotelCategoryField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public int CityId
		{
			get
			{
				return this.cityIdField;
			}
			set
			{
				this.cityIdField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public decimal AgencyCommission
		{
			get
			{
				return this.agencyCommissionField;
			}
			set
			{
				this.agencyCommissionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public System.DateTime CancellationDate
		{
			get
			{
				return this.cancellationDateField;
			}
			set
			{
				this.cancellationDateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public System.DateTime CheckInDate
		{
			get
			{
				return this.checkInDateField;
			}
			set
			{
				this.checkInDateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public System.DateTime PaymentDeadline
		{
			get
			{
				return this.paymentDeadlineField;
			}
			set
			{
				this.paymentDeadlineField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public System.DateTime ReservationDate
		{
			get
			{
				return this.reservationDateField;
			}
			set
			{
				this.reservationDateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string HotelAddress
		{
			get
			{
				return this.hotelAddressField;
			}
			set
			{
				this.hotelAddressField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public int HotelId
		{
			get
			{
				return this.hotelIdField;
			}
			set
			{
				this.hotelIdField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string ServiceId
		{
			get
			{
				return this.serviceIdField;
			}
			set
			{
				this.serviceIdField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string Location
		{
			get
			{
				return this.locationField;
			}
			set
			{
				this.locationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string LogXMLAuditId
		{
			get
			{
				return this.logXMLAuditIdField;
			}
			set
			{
				this.logXMLAuditIdField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string AgencyCurrencyCommission
		{
			get
			{
				return this.agencyCurrencyCommissionField;
			}
			set
			{
				this.agencyCurrencyCommissionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string CityName
		{
			get
			{
				return this.cityNameField;
			}
			set
			{
				this.cityNameField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
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
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public byte NumberOfAdults
		{
			get
			{
				return this.numberOfAdultsField;
			}
			set
			{
				this.numberOfAdultsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public byte NumberOfChildren
		{
			get
			{
				return this.numberOfChildrenField;
			}
			set
			{
				this.numberOfChildrenField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public int NumberOfNights
		{
			get
			{
				return this.numberOfNightsField;
			}
			set
			{
				this.numberOfNightsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string Observation
		{
			get
			{
				return this.observationField;
			}
			set
			{
				this.observationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string VoucherObservation
		{
			get
			{
				return this.voucherObservationField;
			}
			set
			{
				this.voucherObservationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string CountryId
		{
			get
			{
				return this.countryIdField;
			}
			set
			{
				this.countryIdField = value;
			}
		}

		// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public Pax[] Paxs
		{
			get
			{
				return this.paxsField;
			}
			set
			{
				this.paxsField = value;
			}
		}


		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public NetPrice NetPrice
		{
			get
			{
				return this.netPriceField;
			}
			set
			{
				this.netPriceField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public OperatorCancellationPolicies OperatorCancellationPolicies
		{
			get
			{
				return this.operatorCancellationPoliciesField;
			}
			set
			{
				this.operatorCancellationPoliciesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string ReservationId
		{
			get
			{
				return this.reservationIdField;
			}
			set
			{
				this.reservationIdField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string RoomDescription
		{
			get
			{
				return this.roomDescriptionField;
			}
			set
			{
				this.roomDescriptionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string PaymentStatus
		{
			get
			{
				return this.paymentStatusField;
			}
			set
			{
				this.paymentStatusField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string SystemStatus
		{
			get
			{
				return this.systemStatusField;
			}
			set
			{
				this.systemStatusField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public byte ConversionRate
		{
			get
			{
				return this.conversionRateField;
			}
			set
			{
				this.conversionRateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string HotelPhone
		{
			get
			{
				return this.hotelPhoneField;
			}
			set
			{
				this.hotelPhoneField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string ProviderID
		{
			get
			{
				return this.providerIDField;
			}
			set
			{
				this.providerIDField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string ProviderName
		{
			get
			{
				return this.providerNameField;
			}
			set
			{
				this.providerNameField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string ProviderLogo
		{
			get
			{
				return this.providerLogoField;
			}
			set
			{
				this.providerLogoField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string ProviderBookingCode
		{
			get
			{
				return this.providerBookingCodeField;
			}
			set
			{
				this.providerBookingCodeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public System.DateTime PaymentDate
		{
			get
			{
				return this.paymentDateField;
			}
			set
			{
				this.paymentDateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string PaymentType
		{
			get
			{
				return this.paymentTypeField;
			}
			set
			{
				this.paymentTypeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public object Remarks
		{
			get
			{
				return this.remarksField;
			}
			set
			{
				this.remarksField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public CreationUserDetail CreationUserDetail
		{
			get
			{
				return this.creationUserDetailField;
			}
			set
			{
				this.creationUserDetailField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public LastUpdateUserDetail LastUpdateUserDetail
		{
			get
			{
				return this.lastUpdateUserDetailField;
			}
			set
			{
				this.lastUpdateUserDetailField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public object Payments
		{
			get
			{
				return this.paymentsField;
			}
			set
			{
				this.paymentsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public object Taxes
		{
			get
			{
				return this.taxesField;
			}
			set
			{
				this.taxesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string InvoiceItems
		{
			get
			{
				return this.invoiceItemsField;
			}
			set
			{
				this.invoiceItemsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public bool Billed
		{
			get
			{
				return this.billedField;
			}
			set
			{
				this.billedField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayAttribute(Namespace = "WS_2013.Hotel")]
		[System.Xml.Serialization.XmlArrayItemAttribute("Breakdown", IsNullable = false)]
		public Breakdown[] BreakdownSales
		{
			get
			{
				return this.breakdownSalesField;
			}
			set
			{
				this.breakdownSalesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string Type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string AcceptPayment
		{
			get
			{
				return this.acceptPaymentField;
			}
			set
			{
				this.acceptPaymentField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string CancellationType
		{
			get
			{
				return this.cancellationTypeField;
			}
			set
			{
				this.cancellationTypeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public object SupplierExternalReservationCode
		{
			get
			{
				return this.supplierExternalReservationCodeField;
			}
			set
			{
				this.supplierExternalReservationCodeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public object RoomClientReference
		{
			get
			{
				return this.roomClientReferenceField;
			}
			set
			{
				this.roomClientReferenceField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string UrlVoucher
		{
			get
			{
				return this.urlVoucherField;
			}
			set
			{
				this.urlVoucherField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public object HotelCNPJ
		{
			get
			{
				return this.hotelCNPJField;
			}
			set
			{
				this.hotelCNPJField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public decimal PaymentConvertionRate
		{
			get
			{
				return this.paymentConvertionRateField;
			}
			set
			{
				this.paymentConvertionRateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public string PaymentCurrency
		{
			get
			{
				return this.paymentCurrencyField;
			}
			set
			{
				this.paymentCurrencyField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public System.DateTime LastUpdate
		{
			get
			{
				return this.lastUpdateField;
			}
			set
			{
				this.lastUpdateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "WS_2013.Hotel")]
		public bool CanSeeVoucher
		{
			get
			{
				return this.canSeeVoucherField;
			}
			set
			{
				this.canSeeVoucherField = value;
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
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "WS_2013.Hotel")]
	public partial class BreakdownSalesBreakdown
	{

		private BreakdownSalesBreakdownPrice priceField;

		private System.DateTime dateBreakdownField;

		/// <remarks/>
		public BreakdownSalesBreakdownPrice Price
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

		/// <remarks/>
		public System.DateTime DateBreakdown
		{
			get
			{
				return this.dateBreakdownField;
			}
			set
			{
				this.dateBreakdownField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "WS_2013.Hotel")]
	public partial class BreakdownSalesBreakdownPrice
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
	public partial class BreakdownSales
	{

		private BreakdownSalesBreakdown[] breakdownField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Breakdown")]
		public BreakdownSalesBreakdown[] Breakdown
		{
			get
			{
				return this.breakdownField;
			}
			set
			{
				this.breakdownField = value;
			}
		}
	}



	//--------------------------------// GetBookingList //---------------------------------------------//

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ws_2013.services.cangooroo.net/")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://ws_2013.services.cangooroo.net/", IsNullable = false)]
	public partial class getBookingList
	{

		private Credential credentialField;

		private searchBookingCriteria searchBookingCriteriaField;

		/// <remarks/>
		public Credential credential
		{
			get
			{
				return this.credentialField;
			}
			set
			{
				this.credentialField = value;
			}
		}

		/// <remarks/>
		public searchBookingCriteria searchBookingCriteria
		{
			get
			{
				return this.searchBookingCriteriaField;
			}
			set
			{
				this.searchBookingCriteriaField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ws_2013.services.cangooroo.net/")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://ws_2013.services.cangooroo.net/", IsNullable = false)]
	public partial class getBookingListResponse
	{

		private BookingSearchResult[] getBookingListResultField;

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayItemAttribute("BookingSearchResult", IsNullable = false)]
		public BookingSearchResult[] getBookingListResult
		{
			get
			{
				return this.getBookingListResultField;
			}
			set
			{
				this.getBookingListResultField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ws_2013.services.cangooroo.net/")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://ws_2013.services.cangooroo.net/", IsNullable = false)]
	public partial class searchBookingCriteria
	{

		private string initialBookingDateField;

		/// <remarks/>
		public string InitialBookingDate
		{
			get
			{
				return this.initialBookingDateField;
			}
			set
			{
				this.initialBookingDateField = value;
			}
		}

		private string finalBookingDateField;

		/// <remarks/>
		public string FinalBookingDate
		{
			get
			{
				return this.finalBookingDateField;
			}
			set
			{
				this.finalBookingDateField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ws_2013.services.cangooroo.net/")]
	public partial class BookingSearchResult
	{

		private string bookingIdField;

		private string serviceIdField;

		private string serviceTypeField;

		private System.DateTime lastUpdateField;

		private string clientIdField;

		private string externalReferenceField;

		private string mainPaxField;

		private Price priceField;

		private string statusField;

		private System.DateTime serviceDateField;

		private System.DateTime bookingDateField;

		/// <remarks/>
		public string BookingId
		{
			get
			{
				return this.bookingIdField;
			}
			set
			{
				this.bookingIdField = value;
			}
		}

		/// <remarks/>
		public string ServiceId
		{
			get
			{
				return this.serviceIdField;
			}
			set
			{
				this.serviceIdField = value;
			}
		}

		/// <remarks/>
		public string ServiceType
		{
			get
			{
				return this.serviceTypeField;
			}
			set
			{
				this.serviceTypeField = value;
			}
		}

		/// <remarks/>
		public System.DateTime LastUpdate
		{
			get
			{
				return this.lastUpdateField;
			}
			set
			{
				this.lastUpdateField = value;
			}
		}

		/// <remarks/>
		public string ClientId
		{
			get
			{
				return this.clientIdField;
			}
			set
			{
				this.clientIdField = value;
			}
		}

		/// <remarks/>
		public string ExternalReference
		{
			get
			{
				return this.externalReferenceField;
			}
			set
			{
				this.externalReferenceField = value;
			}
		}

		/// <remarks/>
		public string MainPax
		{
			get
			{
				return this.mainPaxField;
			}
			set
			{
				this.mainPaxField = value;
			}
		}

		/// <remarks/>
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

		/// <remarks/>
		public string Status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				this.statusField = value;
			}
		}

		/// <remarks/>
		public System.DateTime ServiceDate
		{
			get
			{
				return this.serviceDateField;
			}
			set
			{
				this.serviceDateField = value;
			}
		}

		/// <remarks/>
		public System.DateTime BookingDate
		{
			get
			{
				return this.bookingDateField;
			}
			set
			{
				this.bookingDateField = value;
			}
		}
	}


}
