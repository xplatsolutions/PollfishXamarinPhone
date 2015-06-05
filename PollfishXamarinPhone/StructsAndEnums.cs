using System;
using System.Runtime.InteropServices;
using ObjCRuntime;
//using pollfish;

namespace PollfishXamarinPhone
{

	public enum GenderValue : uint
	{
		Male,
		Female,
		Other
	}

	public enum RaceValue : uint
	{
		White,
		Caucasian,
		BlackAfrican,
		HispanicLatino,
		AsianPacificIslander,
		ArabicMiddleEastern,
		AmericanIndianAlaskaNativeNativeHawaiian,
		OtherRace
	}

	public enum AgeGroupValue : uint
	{
		_1217,
		_1824,
		_2534,
		_3544,
		_4554,
		_5564,
		_65_plus,
		OtherGroup
	}

	public enum AgeValue : uint
	{
		_12 = 0,
		_13,
		_14,
		_15,
		_16,
		_17,
		_18,
		_19,
		_20,
		_21,
		_22,
		_23,
		_24,
		_25,
		_26,
		_27,
		_28,
		_29,
		_30,
		_31,
		_32,
		_33,
		_34,
		_35,
		_36,
		_37,
		_38,
		_39,
		_40,
		_41,
		_42,
		_43,
		_44,
		_45,
		_46,
		_47,
		_48,
		_49,
		_50,
		_51,
		_52,
		_53,
		_54,
		_55,
		_56,
		_57,
		_58,
		_59,
		_60,
		_61,
		_62,
		_63,
		_64,
		_65,
		_66,
		_67,
		_68,
		_69,
		_70,
		OtherAge
	}

	public enum MaritalStatusValue : uint
	{
		Annuled,
		Divorced,
		Interlocutory,
		Legally,
		Seperated,
		Married,
		Polygamous,
		NeverMarried,
		DomesticPartner,
		Widowed,
		OtherMarritalStatus
	}

	public enum ReligionValue : uint
	{
		Catholic,
		Christian,
		ProtestantChristian,
		OrthodoxChristian,
		AnglicanChristian,
		Muslim,
		Hindu,
		Buddhist,
		Bahai,
		Secular,
		NonReligious,
		Agnostic,
		Atheist,
		OtherReligion
	}

	public enum PoliticalViewValue : uint
	{
		DemocraticParty,
		RepublicanParty,
		LibertarianParty,
		GreenParty,
		ConstitutionParty,
		OtherPoliticalView
	}

	public enum YearOfBirthValue : uint
	{
		_1950,
		_1951,
		_1952,
		_1953,
		_1954,
		_1955,
		_1956,
		_1957,
		_1958,
		_1959,
		_1960,
		_1961,
		_1962,
		_1963,
		_1964,
		_1965,
		_1966,
		_1967,
		_1968,
		_1969,
		_1970,
		_1971,
		_1972,
		_1973,
		_1974,
		_1975,
		_1976,
		_1977,
		_1978,
		_1979,
		_1980,
		_1981,
		_1982,
		_1983,
		_1984,
		_1985,
		_1986,
		_1987,
		_1988,
		_1989,
		_1990,
		_1991,
		_1992,
		_1993,
		_1994,
		_1995,
		_1996,
		_1997,
		_1998,
		_1999,
		_2000,
		_2001,
		_2002,
		_2003,
		_2004,
		_2005,
		_2006,
		_2007,
		OtherYear
	}

	public enum NationalityValue : uint
	{
		Afghan,
		Argentine,
		Australian,
		Belgian,
		Bolivian,
		Brazilian,
		Comodian,
		Cameroonian,
		Canadian,
		Chilean,
		Chinese,
		Colombian,
		CostaRican,
		Cypriot,
		Danish,
		Dominican,
		Ecuadorian,
		Egyptian,
		Salvadorian,
		English,
		Esthonian,
		Ethipian,
		Finnish,
		French,
		German,
		Ghanaian,
		Greek,
		Guatemalan,
		Haitian,
		Honduran,
		Indonesian,
		Iranina,
		Irish,
		Israeli,
		Italian,
		Japanese,
		Jordanian,
		Kenyan,
		Korean,
		Laotian,
		Latvian,
		Lithuanian,
		Malaysian,
		Mexican,
		Moroccan,
		Dutch,
		NewZealander,
		Nicaraguan,
		Norwegian,
		Panamanian,
		Paraguayan,
		Peruvian,
		Filipino,
		Polish,
		Portuguese,
		PuertoRican,
		Romanian,
		Russian,
		Saudi,
		Spanish,
		Swedish,
		Swiss,
		Taiwanese,
		Tajik,
		Thai,
		Turkish,
		Ukrainian,
		American,
		Uruguanyan,
		Venezuelan,
		Vietnamese,
		Welsh,
		OtherNationality
	}

	public enum CountryValue : uint
	{
		Afganistan,
		Argentina,
		Australia,
		Beligum,
		Bolivia,
		Brazil,
		Cambodia,
		Cameroon,
		Canada,
		Chile,
		China,
		Colombia,
		CostaRica,
		Cuba,
		Cyprus,
		Denmark,
		DominicanRepublic,
		RepublicEcuador,
		Egypt,
		ElSlavador,
		England,
		Estonia,
		Ethiopia,
		Finland,
		France,
		Germany,
		Ghana,
		Greece,
		Guatemala,
		Haiti,
		Honduras,
		Indonesia,
		Iran,
		Ireland,
		Israel,
		Italy,
		Japan,
		Jordan,
		Kenya,
		Korea,
		Laos,
		Latvia,
		Lithuania,
		Malaysia,
		Mexico,
		Morocco,
		Netherlnads,
		NewZealand,
		Nicaragua,
		Norway,
		Panama,
		Paraguay,
		Peru,
		Philippines,
		Poland,
		Portugal,
		PuertoRico,
		Romania,
		Russia,
		SaudiArabia,
		Spain,
		Sweden,
		Switzerland,
		Taiwan,
		Tajikistan,
		Thailand,
		Turkey,
		Ukraine,
		UnitedStates,
		Uruguay,
		Venezuela,
		Vietnam,
		Wales,
		OtherCountry
	}

	static class CFunctions
	{
		// extern NSString * GENDER (GENDER_VALUE gender);
		[DllImport ("__Internal")]
//		[Verify (PlatformInvoke)]
		static extern string GENDER (GenderValue gender);

		// extern NSString * RACE (RACE_VALUE race);
		[DllImport ("__Internal")]
//		[Verify (PlatformInvoke)]
		static extern string RACE (RaceValue race);

		// extern NSString * AGE_GROUP (AGE_GROUP_VALUE age_group);
		[DllImport ("__Internal")]
//		[Verify (PlatformInvoke)]
		static extern string AGE_GROUP (AgeGroupValue age_group);

		// extern NSString * AGE (AGE_VALUE age_value);
		[DllImport ("__Internal")]
//		[Verify (PlatformInvoke)]
		static extern string AGE (AgeValue age_value);

		// extern NSString * MARITAL_STATUS (MARITAL_STATUS_VALUE marital_status);
		[DllImport ("__Internal")]
//		[Verify (PlatformInvoke)]
		static extern string MARITAL_STATUS (MaritalStatusValue marital_status);

		// extern NSString * RELIGION (RELIGION_VALUE religion);
		[DllImport ("__Internal")]
//		[Verify (PlatformInvoke)]
		static extern string RELIGION (ReligionValue religion);

		// extern NSString * POLITICAL_VIEW (POLITICAL_VIEW_VALUE political_view);
		[DllImport ("__Internal")]
//		[Verify (PlatformInvoke)]
		static extern string POLITICAL_VIEW (PoliticalViewValue political_view);

		// extern NSString * YEAR_OF_BIRTH (YEAR_OF_BIRTH_VALUE year_of_birth);
		[DllImport ("__Internal")]
//		[Verify (PlatformInvoke)]
		static extern string YEAR_OF_BIRTH (YearOfBirthValue year_of_birth);

		// extern NSString * NATIONALITY (NATIONALITY_VALUE nationality);
		[DllImport ("__Internal")]
//		[Verify (PlatformInvoke)]
		static extern string NATIONALITY (NationalityValue nationality);

		// extern NSString * COUNTRY (COUNTRY_VALUE country);
		[DllImport ("__Internal")]
//		[Verify (PlatformInvoke)]
		static extern string COUNTRY (CountryValue country);
	}

	[Native]
	public enum PollfishPosition : long
	{
		TopLeft,
		TopRight,
		BottomLeft,
		BottomRight,
		MiddleLeft,
		MiddleRight
	}
}

