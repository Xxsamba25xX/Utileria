using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

	namespace TravelgatexHotel.Domain.Request
	{
		public class Selectors
		{
			public static string AdviseMessage => @$"{{
			code
			description
			level
			external{ExternalMessage}
			correlationID
		}}";

			public static string AuditData => @$"{{
			transactions{Transactions}
			timeStamp
			processTime
		}}";

			public static string Error => @$"{{
			code
			type
			description
		}}";

			public static string ExternalMessage => @$"{{
			code
			message
		}}";

			public static string Holder => @$"{{
			name
			surname
		}}";

			public static string PageInfo => @$"{{
			hasNextPage
			hasPreviousPage
			startCursor
			endCursor
		}}";

			public static string PaymentCard => @$"{{
			code
			paymentCardData{PaymentCardData}
			createdAt
			updatedAt
		}}";

			public static string PaymentCardData => @$"{{
			active
			CVC
			expire
			holder{Holder}
			id
			number
			supplier{Supplier}
			type
		}}";

			public static string Text => @$"{{
			text
			language
		}}";

			public static string Transactions => @$"{{
			request
			response
			timeStamp
		}}";

			public static string Urls => @$"{{
			search
			quote
			book
			generic
		}}";

			public static string Warning => @$"{{
			code
			type
			description
		}}";

			public static string Access => @$"{{
			code
			accessData{AccessData}
			error{Error}
			createdAt
			updatedAt
		}}";

			public static string AccessConnection => @$"{{
			edges{AccessEdge}
			pageInfo{PageInfo}
			totalCount
		}}";

			public static string AccessData => @$"{{
			name
			isActive
			code
			supplier{Supplier}
			isTest
			user
			password
			urls{Urls}
			parameters{Parameter}
			markets
			rateRules
			shared{Access}
			owner{Organization}
			updateDescriptiveInfo
			descriptiveInfoLimit
			isSchedulerActive
			updateList
			updateDateRange
			legacyLink{LegacyLink}
			master{Access}
		}}";

			public static string AccessEdge => @$"{{
			node{Access}
			cursor
		}}";

			public static string Client => @$"{{
			code
			clientData{ClientData}
			error{Error}
			createdAt
			updatedAt
		}}";

			public static string ClientConnection => @$"{{
			edges{ClientEdge}
			pageInfo{PageInfo}
			totalCount
		}}";

			public static string ClientData => @$"{{
			code
			name
			isActive
			group{Group}
			owner{Organization}
		}}";

			public static string ClientEdge => @$"{{
			node{Client}
			cursor
		}}";

			public static string Context => @$"{{
			code
			error{Error}
			createdAt
			updatedAt
		}}";

			public static string Entity => @$"{{
			code
			entity
			createdAt
			updatedAt
		}}";

			public static string EntityConnection => @$"{{
			edges{EntityEdge}
			pageInfo{PageInfo}
		}}";

			public static string EntityEdge => @$"{{
			node{Entity}
			cursor
		}}";

			public static string LegacyLink => @$"{{
			hubUser{Client}
			hubProvider{Supplier}
		}}";

			public static string Parameter => @$"{{
			key
			value
		}}";

			public static string PointOfSale => @$"{{
			code
			pointOfSaleData{PointOfSaleData}
			createdAt
			updatedAt
		}}";

			public static string PointOfSaleConnection => @$"{{
			edges{PointOfSaleEdge}
			pageInfo{PageInfo}
		}}";

			public static string PointOfSaleData => @$"{{
			code
			name
			owner{Organization}
		}}";

			public static string PointOfSaleEdge => @$"{{
			node{PointOfSale}
			cursor
		}}";

			public static string Profile => @$"{{
			code
			profileData{ProfileData}
			createdAt
			updatedAt
		}}";

			public static string ProfileConnection => @$"{{
			edges{ProfileEdge}
			pageInfo{PageInfo}
			totalCount
		}}";

			public static string ProfileData => @$"{{
			code
			label
			type
			entities{EntityConnection}
			group{Group}
			owner{Organization}
			isActive
			isPublished
		}}";

			public static string ProfileEdge => @$"{{
			node{Profile}
			cursor
		}}";

			public static string Provider => @$"{{
			code
			name
			isActive
			isPublic
		}}";

			public static string ServiceApi => @$"{{
			code
			name
			operations{ServiceOperation}
			error{Error}
		}}";

			public static string ServiceOperation => @$"{{
			code
			name
			type
			travelOperation
		}}";

			/*ELIMINADO POR ERROR EN CHECKOUT
				supplierData{SupplierData}
				error{Error}
				createdAt
				updatedAt
			 */
			public static string Supplier => @$"{{
			code
			
		}}";

			public static string SupplierConnection => @$"{{
			edges{SupplierEdge}
			pageInfo{PageInfo}
			totalCount
		}}";

			/*ELIMINADOS POR GENERAR RECURSIVIDAD INFINITA
				owner{Organization}
				system{System}
				*/
			public static string SupplierData => @$"{{
			code
			name
			isActive
			provider{Provider}
			context
			serviceApi
			supplierGroup
		}}";

			public static string SupplierEdge => @$"{{
			node{Supplier}
			cursor
		}}";

			public static string SupplierGroup => @$"{{
			groupCode
			isActive
		}}";

			public static string System => @$"{{
			code
			systemData{SystemData}
			error{Error}
			createdAt
			updatedAt
		}}";

			public static string SystemConnection => @$"{{
			edges{SystemEdge}
			pageInfo{PageInfo}
		}}";

			public static string SystemData => @$"{{
			code
			name
			isActive
			group{Group}
			owner{Organization}
		}}";

			public static string SystemEdge => @$"{{
			node{System}
			cursor
		}}";

			public static string API => @$"{{
			code
			apiData{APIData}
			createdAt
			updatedAt
		}}";

			public static string APIConnection => @$"{{
			edges{APIEdge}
			pageInfo{PageInfo}
		}}";

			public static string APIData => @$"{{
			code
			id
			isEditable
			label
		}}";

			public static string APIEdge => @$"{{
			node{API}
			cursor
		}}";

			public static string Partner => @$"{{
			code
			partnerData{PartnerData}
			createdAt
			updatedAt
		}}";

			public static string PartnerConnection => @$"{{
			edges{PartnerEdge}
			pageInfo{PageInfo}
			totalCount
		}}";

			public static string PartnerData => @$"{{
			code
			name
			isActive
			friendlyName
			organizations{OrganizationConnection}
			agents{CustomerAgent}
		}}";

			public static string PartnerEdge => @$"{{
			node{Partner}
			cursor
		}}";

			public static string CustomerAgent => @$"{{
			type
			user{Member}
		}}";

			public static string Domain => @$"{{
			code
			domainData{DomainData}
			createdAt
			updatedAt
		}}";

			public static string DomainData => @$"{{
			id
			name
			organization{Organization}
		}}";

			public static string Group => @$"{{
			code
			groupData{GroupData}
			createdAt
			updatedAt
		}}";

			public static string GroupConnection => @$"{{
			edges{GroupEdge}
			pageInfo{PageInfo}
			totalCount
		}}";

			public static string GroupData => @$"{{
			id
			code
			label
			type
			info
			parent{Group}
			owner{Member}
			isEditable
			productId
			resourceId
		}}";

			public static string GroupEdge => @$"{{
			node{Group}
			cursor
		}}";

			public static string MacroPermission => @$"{{
			code
			macroPermissionData{MacroPermissionData}
			createdAt
			updatedAt
		}}";

			public static string MacroPermissionsConnection => @$"{{
			edges{MacroPermissionEdge}
			pageInfo{PageInfo}
		}}";

			public static string MacroPermissionData => @$"{{
			id
			code
			productID
			group
			label
			permissions{Permission}
		}}";

			public static string MacroPermissionEdge => @$"{{
			node{MacroPermission}
			cursor
		}}";

			public static string ManagedGroup => @$"{{
			code
			managedGroupData{ManagedGroupData}
			createdAt
			updatedAt
		}}";

			public static string ManagedGroupConnection => @$"{{
			edges{ManagedGroupEdge}
			pageInfo{PageInfo}
		}}";

			public static string ManagedGroupData => @$"{{
			code
			group{Group}
			api{API}
			resource{Resource}
			role{Role}
		}}";

			public static string ManagedGroupEdge => @$"{{
			node{ManagedGroup}
			cursor
		}}";

			public static string Member => @$"{{
			code
			memberData{MemberData}
			createdAt
			updatedAt
		}}";

			public static string MemberConnection => @$"{{
			edges{MemberEdge}
			pageInfo{PageInfo}
			totalCount
		}}";

			public static string MemberData => @$"{{
			id
			code
			label
			isActive
			type
		}}";

			public static string MemberEdge => @$"{{
			node{Member}
			cursor
		}}";

			public static string Operation => @$"{{
			code
			operationData{OperationData}
			createdAt
			updatedAt
		}}";

			public static string OperationConnection => @$"{{
			edges{OperationEdge}
			pageInfo{PageInfo}
		}}";

			public static string OperationData => @$"{{
			id
			code
			label
			types
			api{API}
		}}";

			public static string OperationEdge => @$"{{
			node{Operation}
			cursor
		}}";

			public static string Organization => @$"{{
			code
			organizationData{OrganizationData}
			createdAt
			updatedAt
		}}";

			public static string OrganizationConnection => @$"{{
			edges{OrganizationEdge}
			pageInfo{PageInfo}
			totalCount
		}}";

			public static string OrganizationContact => @$"{{
			type
			user{Member}
		}}";

			public static string OrganizationData => @$"{{
			id
			code
			label
			type
			info
			owner{Member}
			contacts{OrganizationContact}
			isEditable
			domains{Domain}
			template
			country
			allAccesses{AccessConnection}
			allSuppliers{SupplierConnection}
			allClients{ClientConnection}
			allProfiles{ProfileConnection}
			primaryPartner{Partner}
		}}";

			public static string OrganizationEdge => @$"{{
			node{Organization}
			cursor
		}}";

			public static string Permission => @$"{{
			role{Role}
			resource{Resource}
			api{API}
		}}";

			public static string Product => @$"{{
			code
			productData{ProductData}
			createdAt
			updatedAt
		}}";

			public static string ProductConnection => @$"{{
			edges{ProductEdge}
			pageInfo{PageInfo}
		}}";

			public static string ProductData => @$"{{
			id
			code
			label
		}}";

			public static string ProductEdge => @$"{{
			node{Product}
			cursor
		}}";

			public static string Resource => @$"{{
			code
			resourceData{ResourceData}
			createdAt
			updatedAt
		}}";

			public static string ResourceConnection => @$"{{
			edges{ResourceEdge}
			pageInfo{PageInfo}
		}}";

			public static string ResourceData => @$"{{
			id
			code
			isEditable
			label
		}}";

			public static string ResourceEdge => @$"{{
			node{Resource}
			cursor
		}}";

			public static string Role => @$"{{
			code
			roleData{RoleData}
			createdAt
			updatedAt
		}}";

			public static string RoleConnection => @$"{{
			edges{RoleEdge}
			pageInfo{PageInfo}
		}}";

			public static string RoleData => @$"{{
			id
			code
			type
			isEditable
			label
			isCreate
			isRead
			isUpdate
			isDelete
			isEnable
			isExecutable
			isSpecial
			special
		}}";

			public static string RoleEdge => @$"{{
			node{Role}
			cursor
		}}";

			public static string Alert => @$"{{
			code
			alertData{AlertData}
			createdAt
			updatedAt
		}}";

			public static string AlertBounds => @$"{{
			bound
			upperBound
			lowerBound
		}}";

			public static string AlertConfiguration => @$"{{
			alertType
			mode
			windowType
			periodicity
			window
			historicalWindow
			offset
			timesToAlert
			timesToRecovery
			typeConfiguration{AlertTypeConfiguration}
			noRecoveries
			stateChangesOnly
			minNumberRequests
			percentageToAlert
			variation
			groupBy
			comercialType
		}}";

			public static string AlertConnection => @$"{{
			edges
			pageInfo
			totalCount
		}}";

			public static string AlertData => @$"{{
			code
			name
			description
			configuration{AlertConfiguration}
			isActive
			editor
			group
		}}";

			public static string AlertEdge => @$"{{
			node{Alert}
			cursor
		}}";

			public static string AlertEvent => @$"{{
			code
			eventData{AlertEventData}
			createdAt
			updatedAt
		}}";

			public static string AlertEventConnection => @$"{{
			edges{AlertEventEdge}
			pageInfo{PageInfo}
			totalCount
		}}";

			public static string AlertEventData => @$"{{
			code
			groupBy
			status
			details
		}}";

			public static string AlertEventEdge => @$"{{
			node{AlertEvent}
			cursor
		}}";

			public static string AlertPrice => @$"{{
			check
			range
			amount
			commission
			amountBy
		}}";

			public static string AlertTypeConfiguration => @$"{{
			maxAverageTime
			maxTime
			requestsToAlert
			toCheck
			toCompare
			price{AlertPrice}
			bounds{AlertBounds}
		}}";

			public static string AmountType => @$"{{
			amount
			curCode
		}}";

			public static string Fee => @$"{{
			amount
			descText
		}}";

			public static string FlightOffer => @$"{{
			code
			flightOfferData{FlightOfferData}
			createdAt
			updatedAt
		}}";

			public static string FlightOfferConnection => @$"{{
			edges{FlightOfferEdge}
			pageInfo{PageInfo}
			totalCount
		}}";

			public static string FlightOfferData => @$"{{
			code
			supplier{Supplier}
			totalPrice
			offerItems{FlightOfferItem}
		}}";

			public static string FlightOfferEdge => @$"{{
			node{FlightOffer}
			cursor
		}}";

			public static string FlightOfferItem => @$"{{
			code
			offerItemData{FlightOfferItemData}
			createdAt
			updatedAt
			adviseMessage{AdviseMessage}
		}}";

			public static string FlightOfferItemData => @$"{{
			code
			price{FlightPrice}
			service{FlightService}
		}}";

			public static string FlightOrder => @$"{{
			code
			flightOrderData{FlightOrderData}
			createdAt
			updatedAt
			adviseMessage{AdviseMessage}
		}}";

			public static string FlightOrderData => @$"{{
			code
			status
			tickets{FlightTicket}
			supplier{Supplier}
			bookingRefIDs
			orderItems{FlightOrderItem}
			totalPrice{FlightPrice}
		}}";

			public static string FlightOrderItem => @$"{{
			code
			flightOrderItemData{FlightOrderItemData}
			createdAt
			updatedAt
			adviseMessage{AdviseMessage}
		}}";

			public static string FlightOrderItemData => @$"{{
			code
			price{FlightPrice}
			service{FlightService}
		}}";

			public static string FlightPax => @$"{{
			age
			type
			paxID
		}}";

			public static string FlightPrice => @$"{{
			baseAmount
			fee{Fee}
			surcharge{FlightSurcharge}
			taxSummary
			totalAmount
		}}";

			public static string FlightSegment => @$"{{
			arrival{TransportArrival}
			departure{TransportDeparture}
			carrier
			flightNumber
		}}";

			public static string FlightService => @$"{{
			code
			flightServiceData{FlightServiceData}
			createdAt
			updatedAt
		}}";

			public static string FlightServiceData => @$"{{
			code
			type
			description
			pax{FlightPax}
		}}";

			public static string FlightSurcharge => @$"{{
			totalAmount
			breakdown{Fee}
		}}";

			public static string FlightTicket => @$"{{
			passenger{Individual}
			number
			status
		}}";

			public static string FlightXQuery => @$"{{
			quote{FlightOffer}
		}}";

			public static string Individual => @$"{{
			code
			name
			surname
			birthDate
			title
		}}";

			public static string TaxSummaryType => @$"{{
			totalTaxAmount
			tax
		}}";

			public static string TaxType => @$"{{
			amount
			descText
		}}";

			public static string TextType => @$"{{
			text
		}}";

			public static string TransportArrival => @$"{{
			location
		}}";

			public static string TransportDeparture => @$"{{
			location
			AircraftScheduled
		}}";

			public static string HotelXCommonSettings => @$"{{
			settings{HotelXCommonSettingsData}
		}}";

			public static string HotelXCommonSettingsData => @$"{{
			currency
			businessRules{BusinessRules}
			timeout{Timeout}
		}}";

			public static string HotelXDefaultPlugin => @$"{{
			step
			type
			name
			run{HotelXParameter}
			init{HotelXParameter}
		}}";

			public static string HotelXDefaultPluginStep => @$"{{
			step
			plugins{HotelXDefaultPlugin}
		}}";

			public static string HotelXDefaultSettings => @$"{{
			settings{HotelXDefaultSettingsData}
		}}";

			public static string HotelXDefaultSettingsData => @$"{{
			context
			language
			currency
			nationality
			markets
			timeout{Timeout}
			businessRules{BusinessRules}
			accesses
			cache
			plugins{HotelXDefaultPluginStep}
		}}";

			public static string HotelXParameter => @$"{{
			key
			value
		}}";

			public static string HotelXUpdateStatus => @$"{{
			code
			hotelXUpdateStatusData{HotelXUpdateStatusData}
			createdAt
			updatedAt
		}}";

			public static string HotelXUpdateStatusData => @$"{{
			code
			isActive
		}}";

			public static string Airport => @$"{{
			code
			airportData{AirportData}
			createdAt
			updatedAt
		}}";

			public static string AirportData => @$"{{
			code
			name
		}}";

			public static string AmenityStatic => @$"{{
			code
			type
		}}";

			public static string BedStatic => @$"{{
			type
			count
			shared
		}}";

			public static string Board => @$"{{
			code
			boardData{BoardData}
			createdAt
			updatedAt
		}}";

			public static string BoardConnection => @$"{{
			edges{BoardEdge}
			pageInfo{PageInfo}
		}}";

			public static string BoardData => @$"{{
			code
			boardCode
		}}";

			public static string BoardEdge => @$"{{
			node{Board}
			cursor
		}}";

			public static string Category => @$"{{
			code
			categoryData{CategoryData}
			createdAt
			updatedAt
		}}";

			public static string CategoryConnection => @$"{{
			edges{CategoryEdge}
			pageInfo{PageInfo}
		}}";

			public static string CategoryData => @$"{{
			code
			categoryCode
		}}";

			public static string CategoryEdge => @$"{{
			node{Category}
			cursor
		}}";

			public static string CheckInformation => @$"{{
			minAge
			schedule{TimeRange}
		}}";

			public static string Contact => @$"{{
			email
			telephone
			fax
			web
		}}";

			public static string Coordinates => @$"{{
			latitude
			longitude
		}}";

			public static string Description => @$"{{
			type
			texts{Text}
		}}";

			public static string Destination => @$"{{
			code
			destinationData{DestinationData}
			createdAt
			updatedAt
		}}";

			public static string DestinationConnection => @$"{{
			edges{DestinationEdge}
			token
			pageInfo{PageInfo}
		}}";

			public static string DestinationData => @$"{{
			code
			available
			destinationLeaf
			closestDestinations
			parent
			type
		}}";

			public static string DestinationEdge => @$"{{
			node{Destination}
			cursor
		}}";

			public static string Geoname => @$"{{
			code
			geonameData{GeonameData}
			createdAt
			updatedAt
		}}";

			public static string GeonameData => @$"{{
			code
			name
			country
			type
			coordinates{Coordinates}
		}}";

			public static string GiataData => @$"{{
			id
			source
			href
			updatedAt
		}}";

			public static string Hotel => @$"{{
			code
			hotelData{HotelData}
			createdAt
			updatedAt
		}}";

			public static string HotelConnection => @$"{{
			edges{HotelEdge}
			count
			token
			pageInfo{PageInfo}
		}}";

			public static string HotelData => @$"{{
			code
			hotelCode
			hotelCodeSupplier
			giataData{GiataData}
			hotelName
			categoryCode
			property{Property}
			chainCode
			exclusiveDeal
			location{Location}
			contact{Contact}
			rank
			cardTypes
			amenities{AmenityStatic}
			medias{Media}
			rooms{RoomConnection}
			mandatoryFees{MandatoryFee}
			checkIn{CheckInformation}
			checkOut{CheckInformation}
		}}";

			public static string HotelEdge => @$"{{
			node{Hotel}
			cursor
		}}";

			public static string HotelXAmenity => @$"{{
			code
			amenityData{HotelXAmenityData}
			createdAt
			updatedAt
		}}";

			public static string HotelXAmenityConnection => @$"{{
			edges{HotelXAmenityEdge}
			pageInfo{PageInfo}
		}}";

			public static string HotelXAmenityData => @$"{{
			code
			amenityCode
			type
			mappings{HotelXMappedCode}
		}}";

			public static string HotelXAmenityEdge => @$"{{
			node{HotelXAmenity}
			cursor
		}}";

			public static string HotelXMappedCode => @$"{{
			context
			code
		}}";

			public static string Location => @$"{{
			address
			city
			zipCode
			country
			coordinates{Coordinates}
			closestDestination{DestinationData}
			airports{Airport}
			geoNames{Geoname}
			state
		}}";

			public static string MandatoryFee => @$"{{
			duration
			mandatoryFeeCode
			price{PriceStatic}
			scope
			name
			text
			included
		}}";

			public static string Media => @$"{{
			code
			order
			type
			updatedAt
			url
		}}";

			public static string Metadata => @$"{{
			code
			metadataData{MetadataData}
			createdAt
			updatedAt
		}}";

			public static string AgeRange => @$"{{
			min
			max
			type
		}}";

			public static string MetadataBeds => @$"{{
			informNumberOfUnits{ReviewedBool}
			informSharedBed{ReviewedBool}
			informBedType{ReviewedBool}
			informNumberOfBeds{ReviewedBool}
		}}";

			public static string MetadataBook => @$"{{
			allowsDeltaPrice{ReviewedBool}
			requiredAllPassengers{ReviewedBool}
			allowsRemarks{ReviewedBool}
			informBillingSupplier{ReviewedBool}
			informHotelReference{ReviewedBool}
			informPrice{ReviewedBool}
			requiredNationality{ReviewedBool}
		}}";

			public static string MetadataBooking => @$"{{
			queryableBySupplierReference{ReviewedBool}
			queryableByClientReference{ReviewedBool}
			queryableByCreationDate{ReviewedBool}
			queryableByCheckinDate{ReviewedBool}
			informHotelReference{ReviewedBool}
			informCancelPolicies{ReviewedBool}
			informPriceCancel{ReviewedBool}
		}}";

			public static string MetadataCancel => @$"{{
			mutableBySupplierReference{ReviewedBool}
			mutableByClientReference{ReviewedBool}
			informPriceCancel{ReviewedBool}
		}}";

			public static string MetadataCandidate => @$"{{
			min
			max
			type
		}}";

			public static string MetadataConnection => @$"{{
			edges{MetadataEdge}
			pageInfo{PageInfo}
		}}";

			public static string MetadataContent => @$"{{
			languages{ReviewedText}
		}}";

			public static string MetadataData => @$"{{
			supplierCode
			search{MetadataSearch}
			quote{MetadataQuote}
			book{MetadataBook}
			booking{MetadataBooking}
			cancel{MetadataCancel}
			hotels{MetadataContent}
			destinations{MetadataContent}
			rooms{MetadataContent}
			boards{MetadataContent}
			categories{MetadataContent}
			markets{MetadataContent}
			currencies{MetadataContent}
			amenities{MetadataContent}
		}}";

			public static string MetadataEdge => @$"{{
			node{Metadata}
			cursor
		}}";

			public static string MetadataQuote => @$"{{
			informBindingPrice{ReviewedBool}
			informNRFRate{ReviewedBool}
			informRemarks{ReviewedBool}
			informCancelPolicies{ReviewedBool}
			informCancelPoliciesDescription{ReviewedBool}
			informSurcharges{ReviewedBool}
			requiredNationality{ReviewedBool}
		}}";

			public static string RequiredRoomWithSamePaxConfiguration => @$"{{
			samePaxNumber{ReviewedBool}
			samePaxAge{ReviewedBool}
		}}";

			public static string ReviewedAgeRanges => @$"{{
			reviewDate
			ages{AgeRange}
		}}";

			public static string ReviewedBool => @$"{{
			reviewDate
			value
		}}";

			public static string ReviewedInt => @$"{{
			reviewDate
			value
		}}";

			public static string ReviwedPaxTypeRangeInRoomCandidates => @$"{{
			reviewDate
			candidates{MetadataCandidate}
		}}";

			public static string ReviewedPaymentType => @$"{{
			reviewDate
			value
		}}";

			public static string ReviewedRateRule => @$"{{
			reviewDate
			value
		}}";

			public static string ReviewedText => @$"{{
			reviewDate
			value
		}}";

			public static string MetadataRoomCandidates => @$"{{
			maxNumberRoomCandidates{ReviewedInt}
			paxTypeRangeInRoomCandidates{ReviwedPaxTypeRangeInRoomCandidates}
			maxPaxInRoomCandidates{ReviewedInt}
			maxPaxInAllRooms{ReviewedInt}
			requiredRoomWithSamePaxConfiguration{RequiredRoomWithSamePaxConfiguration}
			rateRules{ReviewedRateRule}
			beds{MetadataBeds}
			ageRange{ReviewedAgeRanges}
		}}";

			public static string MetadataSearch => @$"{{
			destinations{MetadataSearchDestinations}
			allowsCurrency{ReviewedBool}
			implementsCombination{ReviewedBool}
			numMarketsAllowed{ReviewedInt}
			release{ReviewedInt}
			minimumStay{ReviewedInt}
			maxStay{ReviewedInt}
			roomCandidates{MetadataRoomCandidates}
			informBindingPrice{ReviewedBool}
			informCancelPolicies{ReviewedBool}
			informRoomCancelPolicies{ReviewedBool}
			informRemarks{ReviewedBool}
			paymentTypes
			languages{ReviewedText}
			informDailyPrice{ReviewedBool}
			informDailyRatePlan{ReviewedBool}
			informPromotions{ReviewedBool}
			informNRFRateByRoom{ReviewedBool}
			informSurcharges{ReviewedBool}
			informRoomSurcharges{ReviewedBool}
			informHotelName{ReviewedBool}
			requiredNationality{ReviewedBool}
		}}";

			public static string MetadataSearchDestinations => @$"{{
			maxNumberHotels{ReviewedInt}
			recommendedNumberHotels{ReviewedInt}
		}}";

			public static string OccupancyRange => @$"{{
			min
			max
		}}";

			public static string OccupancyStatic => @$"{{
			total{OccupancyRange}
			infants{OccupancyRange}
			children{OccupancyRange}
			adults{OccupancyRange}
		}}";

			public static string PriceStatic => @$"{{
			amount
			currency
		}}";

			public static string Property => @$"{{
			name
			code
		}}";

			public static string PropertyType => @$"{{
			propertyCode
			name
		}}";

			public static string RoomConnection => @$"{{
			edges{RoomEdge}
			token
			pageInfo{PageInfo}
		}}";

			public static string RoomData => @$"{{
			code
			roomCode
			source
			occupancies{OccupancyStatic}
			amenities{AmenityStatic}
			views{View}
			medias{Media}
			beds{BedStatic}
			area
		}}";

			public static string RoomEdge => @$"{{
			node{RoomStatic}
			cursor
		}}";

			public static string RoomStatic => @$"{{
			code
			roomData{RoomData}
			createdAt
			updatedAt
		}}";

			public static string TimeRange => @$"{{
			startTime
			endTime
		}}";

			public static string View => @$"{{
			viewCode
		}}";

			public static string AddOn => @$"{{
			key
			value
		}}";

			public static string AddOns => @$"{{
			distribute
			distribution{AddOn}
		}}";

			public static string Amenity => @$"{{
			code
			amenityCodeSupplier
			type
			value
			texts
		}}";

			public static string Bed => @$"{{
			type
			count
			shared
		}}";

			public static string BookingHotel => @$"{{
			creationDate
			checkIn
			checkOut
			bookingDate
			start
			end
			hotelCode
			hotelName
			boardCode
			occupancies{Occupancy}
			rooms{BookingRoom}
		}}";

			public static string BookingRoom => @$"{{
			occupancyRefId
			code
			description
			price{Price}
		}}";

			public static string BusinessRules => @$"{{
			optionsQuota
			businessRulesType
		}}";

			public static string CancelPenalty => @$"{{
			deadline
			hoursBefore
			penaltyType
			currency
			value
		}}";

			public static string CancelPolicy => @$"{{
			refundable
			cancelPenalties{CancelPenalty}
		}}";

			public static string ConnectUser => @$"{{
			code
			isActive
			connectUserGroups{ConnectUserGroup}
		}}";

			public static string ConnectUserGroup => @$"{{
			groupCode
			isActive
		}}";

			public static string CriteriaSearch => @$"{{
			checkIn
			checkOut
			hotels
			occupancies{RoomCriteria}
			language
			currency
			nationality
			market
		}}";

			public static string DefaultSettings => @$"{{
			connectUser
			context
			language
			currency
			nationality
			market
			timeouts{Timeout}
			businessRules{BusinessRules}
		}}";

			public static string Exchange => @$"{{
			currency
			rate
		}}";

			public static string Feature => @$"{{
			code
		}}";

			public static string GroupAccess => @$"{{
			groupCodes
			accesses{Access}
		}}";

			public static string HotelBookPayload => @$"{{
			auditData{AuditData}
			booking{HotelBookingDetail}
			errors{Error}
			warnings{Warning}
		}}";

			public static string HotelBooking => @$"{{
			auditData{AuditData}
			bookings{HotelBookingDetail}
			errors{Error}
			warnings{Warning}
		}}";

			public static string HotelBookingDetail => @$"{{
			reference{Reference}
			holder{Holder}
			hotel{BookingHotel}
			price{Price}
			quotePrice{PriceChange}
			cancelPolicy{CancelPolicy}
			remarks
			status
			billingSupplierCode
			payable
			addOns{AddOns}
			paymentCard{PaymentCard}
		}}";

			public static string HotelCancelDetail => @$"{{
			reference{Reference}
			cancelReference
			status
			price{Price}
			booking{HotelBookingDetail}
		}}";

			public static string HotelCancelPayload => @$"{{
			auditData{AuditData}
			cancellation{HotelCancelDetail}
			errors{Error}
			warnings{Warning}
		}}";

			public static string HotelCommitDetails => @$"{{
			reference{Reference}
			status
		}}";

			public static string HotelCommitPayload => @$"{{
			auditData{AuditData}
			commitDetails{HotelCommitDetails}
			errors{Error}
			warnings{Warning}
		}}";

			public static string HotelOptionQuote => @$"{{
			optionRefId
			status
			price{Price}
			searchPrice{PriceChange}
			cancelPolicy{CancelPolicy}
			remarks
			surcharges{Surcharge}
			cardTypes
			addOns{AddOns}
		}}";

			public static string HotelOptionSearch => @$"{{
			supplierCode
			accessCode
			markets
			hotelCode
			hotelCodeSupplier
			hotelName
			boardCode
			boardCodeSupplier
			paymentType
			status
			occupancies{Occupancy}
			rooms{Room}
			price{Price}
			supplements{Supplement}
			surcharges{Surcharge}
			rateRules
			cancelPolicy{CancelPolicy}
			remarks
			addOns{AddOns}
			id
			amenities{Amenity}
		}}";

			public static string HotelQuote => @$"{{
			auditData{AuditData}
			optionQuote{HotelOptionQuote}
			errors{Error}
			warnings{Warning}
		}}";

			public static string HotelRuntimeConfiguration => @$"{{
			code
			hotelRuntimeConfigurationData{HotelRuntimeConfigurationData}
			createdAt
			updatedAt
		}}";

			public static string HotelRuntimeConfigurationData => @$"{{
			hotelRuntimeParameters{HotelRuntimeParameter}
		}}";

			public static string HotelRuntimeParameter => @$"{{
			tagRuntime
			providerTagName
			show
			pattern
			description
			type
			key
			defaultValue
			exampleValue
			possibleValues
			mandatory
		}}";

			public static string HotelSearch => @$"{{
			context
			auditData{AuditData}
			requestCriteria{CriteriaSearch}
			options{HotelOptionSearch}
			errors{Error}
			warnings{Warning}
		}}";

			public static string Map => @$"{{
			code
			maps
		}}";

			public static string Mapping => @$"{{
			errors{Error}
			warnings{Warning}
		}}";

			public static string MappingContext => @$"{{
			code
		}}";

			public static string MappingEntity => @$"{{
			code
		}}";

			public static string Markup => @$"{{
			channel
			currency
			binding
			net
			gross
			exchange{Exchange}
			rules{Rule}
		}}";

			public static string Occupancy => @$"{{
			id
			paxes{Pax}
		}}";

			public static string Pax => @$"{{
			age
		}}";

			public static string Price => @$"{{
			currency
			binding
			net
			gross
			exchange{Exchange}
			markups{Markup}
		}}";

			public static string PriceBreakdown => @$"{{
			effectiveDate
			expireDate
			start
			end
			price{Price}
		}}";

			public static string PriceChange => @$"{{
			currency
			net
			gross
			binding
		}}";

			public static string Promotion => @$"{{
			code
			name
			effectiveDate
			expireDate
			start
			end
		}}";

			public static string RatePlan => @$"{{
			code
			supplierCode
			name
			effectiveDate
			expireDate
			start
			end
		}}";

			public static string Reference => @$"{{
			client
			supplier
			commit
			hotel
			bookingID
		}}";

			public static string Resort => @$"{{
			code
			name
			description
		}}";

			public static string Room => @$"{{
			occupancyRefId
			legacyRoomId
			code
			supplierCode
			description
			refundable
			units
			roomPrice{RoomPrice}
			beds{Bed}
			ratePlans{RatePlan}
			promotions{Promotion}
			surcharges{Surcharge}
			features{Feature}
			amenities{Amenity}
		}}";

			public static string RoomCriteria => @$"{{
			paxes{Pax}
		}}";

			public static string RoomPrice => @$"{{
			price{Price}
			breakdown{PriceBreakdown}
		}}";

			public static string Rule => @$"{{
			id
			name
			type
			value
		}}";

			public static string ServiceStatus => @$"{{
			code
			type
			description
		}}";

			public static string Stat => @$"{{
			start
			end
			duration
		}}";

			public static string StatAccess => @$"{{
			name
			total{Stat}
			staticConfiguration{Stat}
			hotels
			zones
			cities
			requestAccess{StatPlugin}
			responseAccess{StatPlugin}
			transactions{StatTransaction}
			plugins{StatPlugin}
		}}";

			public static string StatPlugin => @$"{{
			name
			total{Stat}
		}}";

			public static string StatTransaction => @$"{{
			reference
			total{Stat}
			buildRequest{Stat}
			workerCommunication{Stat}
			parseResponse{Stat}
		}}";

			public static string StatsRequest => @$"{{
			total{Stat}
			validation{Stat}
			process{Stat}
			configuration{Stat}
			request{Stat}
			response{Stat}
			requestPlugin{StatPlugin}
			responsePlugin{StatPlugin}
			hotels
			zones
			cities
			dockerID
			Accesses{StatAccess}
		}}";

			public static string Supplement => @$"{{
			code
			name
			description
			supplementType
			chargeType
			mandatory
			durationType
			quantity
			unit
			effectiveDate
			expireDate
			start
			end
			resort{Resort}
			price{Price}
		}}";

			public static string Surcharge => @$"{{
			code
			chargeType
			mandatory
			price{Price}
			description
		}}";

			public static string Timeout => @$"{{
			search
			quote
			book
		}}";

			public static string Aggregate => @$"{{
			sum{AggregateSum}
			max{AggregateMax}
		}}";

			public static string AggregateMax => @$"{{
			nights
			bookingWindow
		}}";

			public static string AggregateSum => @$"{{
			amount
			amountEur
			bookings
			nights
			bookingWindow
		}}";

			public static string AmountCancelPenalty => @$"{{
			currency
			amount
			amountEur
		}}";

			public static string BookingAggregation => @$"{{
			status
			client{Client}
			supplier{Supplier}
			currency
			bookingAt
			checkInAt
			cancelAt
			originMarket
			destinationCountry
			paxType
			bookingWindow
			lengthOfStay
			hotelName
			amount
			amountEur
			amountCancelPenalties{AmountCancelPenalty}
			numBookings
			aggregate{Aggregate}
		}}";

			public static string BookingDetail => @$"{{
			reference{Reference}
			holder{Holder}
			hotel{BookingHotel}
			price{Price}
			cancelPolicy{CancelPolicy}
			remarks
			status
			payable
			sessionIdQuote
			sessionIdBooking
			sessionIdCancel
			client{Client}
			supplier{Supplier}
			access{Access}
			executionTime
			timeout
			errorCode
		}}";

			public static string HotelXMappingReportResponse => @$"{{
			data{RetrieveHotelXMappingReport}
			error{AdviseMessage}
		}}";

			public static string InsightsXBookingAggregation => @$"{{
			code
			InsightsXBookingAggregationData{BookingAggregation}
			createdAt
			updatedAt
		}}";

			public static string InsightsXBookingAggregationConnection => @$"{{
			edges{InsightsXBookingAggregationEdge}
			pageInfo{PageInfo}
		}}";

			public static string InsightsXBookingAggregationEdge => @$"{{
			node{InsightsXBookingAggregation}
			cursor
		}}";

			public static string InsightsXBookingDetail => @$"{{
			code
			InsightsXBookingDetailData{BookingDetail}
			createdAt
			updatedAt
		}}";

			public static string InsightsXBookingDetailConnection => @$"{{
			edges{InsightsXBookingDetailEdge}
			pageInfo{PageInfo}
		}}";

			public static string InsightsXBookingDetailEdge => @$"{{
			node{InsightsXBookingDetail}
			cursor
		}}";

			public static string InsightsXBookingReport => @$"{{
			bookingsDetails{InsightsXBookingDetailConnection}
			bookingsAggregation{InsightsXBookingAggregationConnection}
		}}";

			public static string RetrieveHotelXMappingReport => @$"{{
			url
		}}";

			public static string AuditRule => @$"{{
			code
			auditRuleData{AuditRuleData}
			createdAt
			updatedAt
		}}";

			public static string AuditRuleConnection => @$"{{
			edges{AuditRuleEdge}
			pageInfo{PageInfo}
		}}";

			public static string AuditRuleData => @$"{{
			product{Product}
			group{Group}
			access{Access}
			client{Client}
			error{AdviseMessage}
			ttl
			remainingTTL
			percentageToAudit
			auditStatus
		}}";

			public static string AuditRuleEdge => @$"{{
			cursor
			node{AuditRule}
		}}";

			public static string Environment => @$"{{
			code
			type
			worker
		}}";

			public static string Logging => @$"{{
			code
			LoggingData{LoggingData}
			createdAt
			updatedAt
		}}";

			public static string LoggingConnection => @$"{{
			edges{LoggingEdge}
			pageInfo{PageInfo}
		}}";

			public static string LoggingData => @$"{{
			product
			timestamp
			level
			message
			tgx{TGX}
			document
		}}";

			public static string LoggingEdge => @$"{{
			cursor
			node{Logging}
		}}";

			public static string LoggingLegacy => @$"{{
			code
			LoggingLegacyData{LoggingLegacyData}
			createdAt
			updatedAt
		}}";

			public static string LoggingLegacyConnection => @$"{{
			edges{LoggingLegacyEdge}
			pageInfo{PageInfo}
		}}";

			public static string LoggingLegacyData => @$"{{
			code
			timestamp
			sessionID
			access{Access}
			client{Client}
			operation{Operation}
			trafficType
			cloudEnvironment{Environment}
			statusType
			errorCode
			execTime
			url
			unencryptedURL
		}}";

			public static string LoggingLegacyEdge => @$"{{
			cursor
			node{LoggingLegacy}
		}}";

			public static string TGX => @$"{{
			member_id
			layer
			is_private
			included_groups
			excluded_groups
			tgx_correlation_id
			tgx_origin
			tgx_origin_ip
			gstorage_url
			transaction_type
		}}";

			public static string TGXFilter => @$"{{
			member_id
			layer
			is_private
			included_groups
			excluded_groups
			tgx_correlation_id
			tgx_origin
			tgx_origin_ip
			transaction_type
			gstorage_url
		}}";

			public static string File => @$"{{
			fileName
			fileId
			uploadTime
		}}";

			public static string GetMappeaStatsData => @$"{{
			supplierMapped
			startTime
			endTime
			organizationHotels
			contextHotels
			suggestedHotels
		}}";

			public static string GetMappeaStatsResponse => @$"{{
			data{GetMappeaStatsData}
			error{Error}
			warnings{Warning}
		}}";

			public static string GetUploadedFilesData => @$"{{
			files{File}
		}}";

			public static string GetUploadedFilesResponse => @$"{{
			data{GetUploadedFilesData}
			error{Error}
			warnings{Warning}
		}}";

			public static string OnlyStatusResponse => @$"{{
			error{Error}
			warnings{Warning}
		}}";

			public static string SupplierDetected => @$"{{
			code
			supplier{Supplier}
			numberOfHotels
		}}";

			public static string UploadFileData => @$"{{
			fileId
			suppliers{SupplierDetected}
			numberOfLines
			numberOfHotels
		}}";

			public static string UploadFileResponse => @$"{{
			data{UploadFileData}
			error{Error}
			warnings{Warning}
		}}";

			public static string PaymentXExpireDate => @$"{{
			month
			year
		}}";

			public static string PaymentXStoredCard => @$"{{
			code
			storedCardData{PaymentXStoredCardData}
			createdAt
			updatedAt
		}}";

			public static string PaymentXStoredCardConnection => @$"{{
			edges{PaymentXStoredCardEdge}
			pageInfo{PageInfo}
		}}";

			public static string PaymentXStoredCardData => @$"{{
			instance{Group}
			pointOfSale{PointOfSale}
			bookingReference
			checkOut
			checkIn
			cardType
			holder{Holder}
			number
			CVC
			expire{PaymentXExpireDate}
		}}";

			public static string PaymentXStoredCardEdge => @$"{{
			cursor
			node{PaymentXStoredCard}
		}}";

			public static string ConnectionConnection => @$"{{
			edges{ConnectionEdge}
			pageInfo{PageInfo}
		}}";

			public static string ConnectionEdge => @$"{{
			node
			cursor
		}}";

			public static string OperationDetailed => @$"{{
			operation{Operation}
			totalHits
			cache
			trafficType
		}}";

			public static string Ratios => @$"{{
			lookToQuote
			lookToBook
			quoteToBook
		}}";

			public static string Stats => @$"{{
			code
			statsData{StatsData}
			createdAt
			updatedAt
		}}";

			public static string StatsAsset => @$"{{
			startTime
			execTime
			url
			unencryptedURL
		}}";

			public static string StatsConnection => @$"{{
			edges{StatsEdge}
			pageInfo{PageInfo}
		}}";

			public static string StatsData => @$"{{
			access{Access}
			client{Client}
			from
			to
		}}";

			public static string StatsEdge => @$"{{
			node{Stats}
			cursor
		}}";

			public static string StatsInfo => @$"{{
			code
			type
			hits
			time
			averageTime
			totalTime
			assets{StatsAsset}
		}}";

			public static string AdminQuery => @$"{{
			jwt
		}}";

			public static string Mutation => @$"{{
			admin
			hotelX
			mappea
			paymentX
			alertsX
			flightX
			logging
		}}";

			public static string HotelXQuery => @$"{{
			hotelConfigurationStatusService{ServiceStatus}
			searchStatusService{ServiceStatus}
			quoteStatusService{ServiceStatus}
			bookStatusService{ServiceStatus}
			cancelStatusService{ServiceStatus}
			bookingStatusService{ServiceStatus}
			commitStatusService{ServiceStatus}
		}}";

			public static string Query => @$"{{
			admin{AdminQuery}
			hotelX{HotelXQuery}
			mappea{MappeaQuery}
			paymentX{PaymentXQuery}
			stats
			insights
			alertsX
			flightX{FlightXQuery}
			logging
		}}";

			public static string MappeaQuery => @$"{{
			getUploadedFiles{GetUploadedFilesResponse}
		}}";

			public static string PaymentXQuery => @$"{{
			vaultStatusService{AdviseMessage}
		}}";
		}
	}


}
