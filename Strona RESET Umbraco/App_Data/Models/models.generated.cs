//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.0.90
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;



namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Home</summary>
	[PublishedContentModel("home")]
	public partial class Home : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "home";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Home(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Galeria</summary>
	[PublishedContentModel("galeria")]
	public partial class Galeria : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "galeria";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Galeria(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Galeria, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Projekty</summary>
	[PublishedContentModel("projekty")]
	public partial class Projekty : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "projekty";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Projekty(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Projekty, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Kontakt</summary>
	[PublishedContentModel("kontakt")]
	public partial class Kontakt : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "kontakt";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Kontakt(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Kontakt, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Aktualnosci</summary>
	[PublishedContentModel("aktualnosci")]
	public partial class Aktualnosci : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "aktualnosci";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Aktualnosci(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Aktualnosci, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>AktualnosciSzczegoly</summary>
	[PublishedContentModel("aktualnosciSzczegoly")]
	public partial class AktualnosciSzczegoly : Aktualnosci
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "aktualnosciSzczegoly";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public AktualnosciSzczegoly(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<AktualnosciSzczegoly, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Data i godzina: Data i godzina wydarzenia
		///</summary>
		[ImplementPropertyType("dateAndHour")]
		public DateTime DateAndHour
		{
			get { return this.GetPropertyValue<DateTime>("dateAndHour"); }
		}

		///<summary>
		/// Link Facebook: Link do wydarzenia na FB
		///</summary>
		[ImplementPropertyType("eventFbLink")]
		public string EventFbLink
		{
			get { return this.GetPropertyValue<string>("eventFbLink"); }
		}

		///<summary>
		/// Miejsce wydarzenia: Gdzie odbywa się wydarzenie np. L128, ATH
		///</summary>
		[ImplementPropertyType("eventRoom")]
		public IHtmlString EventRoom
		{
			get { return this.GetPropertyValue<IHtmlString>("eventRoom"); }
		}

		///<summary>
		/// LinkDoGalerii: Link do galerii z danego wydarzenia
		///</summary>
		[ImplementPropertyType("galleryLink")]
		public string GalleryLink
		{
			get { return this.GetPropertyValue<string>("galleryLink"); }
		}

		///<summary>
		/// Opis aktualności: Opis aktualności w szczegółach
		///</summary>
		[ImplementPropertyType("mainDesc")]
		public IHtmlString MainDesc
		{
			get { return this.GetPropertyValue<IHtmlString>("mainDesc"); }
		}

		///<summary>
		/// Tytuł aktualności: Tytuł aktualności w szczegółach
		///</summary>
		[ImplementPropertyType("mainTitle")]
		public IHtmlString MainTitle
		{
			get { return this.GetPropertyValue<IHtmlString>("mainTitle"); }
		}

		///<summary>
		/// PrzypnijPost: Przypięcie posta sprawi, że będzie on wyświetlał się zawsze na samej górze aktualności
		///</summary>
		[ImplementPropertyType("pinPost")]
		public bool PinPost
		{
			get { return this.GetPropertyValue<bool>("pinPost"); }
		}

		///<summary>
		/// Data: Data, kiedy odbywa się wydarzenie
		///</summary>
		[ImplementPropertyType("shortDate")]
		public string ShortDate
		{
			get { return this.GetPropertyValue<string>("shortDate"); }
		}

		///<summary>
		/// Krótki opis aktualności: Opis wyświetlany na stronie głównej oraz na liście aktualności
		///</summary>
		[ImplementPropertyType("shortDesc")]
		public IHtmlString ShortDesc
		{
			get { return this.GetPropertyValue<IHtmlString>("shortDesc"); }
		}

		///<summary>
		/// Infografika: Infografika 900x900 [px]
		///</summary>
		[ImplementPropertyType("shortIcon")]
		public object ShortIcon
		{
			get { return this.GetPropertyValue("shortIcon"); }
		}

		///<summary>
		/// Tytuł aktualności: Tytuł wyświetlany na stronie głównej oraz na liście aktualności
		///</summary>
		[ImplementPropertyType("shortTitle")]
		public IHtmlString ShortTitle
		{
			get { return this.GetPropertyValue<IHtmlString>("shortTitle"); }
		}

		///<summary>
		/// Opis: Opis prelegenta 1
		///</summary>
		[ImplementPropertyType("speaker1Desc")]
		public IHtmlString Speaker1Desc
		{
			get { return this.GetPropertyValue<IHtmlString>("speaker1Desc"); }
		}

		///<summary>
		/// Prelegent 1 link Facebook: Link do facebook'a prelegenta 1
		///</summary>
		[ImplementPropertyType("speaker1FbLink")]
		public string Speaker1FbLink
		{
			get { return this.GetPropertyValue<string>("speaker1FbLink"); }
		}

		///<summary>
		/// Zdjęcie prelegenta 1: Zdjęcie prelegenta 1  450x450 [px]
		///</summary>
		[ImplementPropertyType("speaker1Img")]
		public object Speaker1Img
		{
			get { return this.GetPropertyValue("speaker1Img"); }
		}

		///<summary>
		/// Prelegent 1 link LinkedIn: Link do LinkedIn prelegenta 1
		///</summary>
		[ImplementPropertyType("speaker1LinkedInLink")]
		public string Speaker1LinkedInLink
		{
			get { return this.GetPropertyValue<string>("speaker1LinkedInLink"); }
		}

		///<summary>
		/// Imię i Nazwisko: Imię i Nazwisko prelegenta 1
		///</summary>
		[ImplementPropertyType("speaker1Name")]
		public IHtmlString Speaker1Name
		{
			get { return this.GetPropertyValue<IHtmlString>("speaker1Name"); }
		}

		///<summary>
		/// Prelegent 1 link Twitter: Link do twittera prelegenta 1
		///</summary>
		[ImplementPropertyType("speaker1TwitterLink")]
		public string Speaker1TwitterLink
		{
			get { return this.GetPropertyValue<string>("speaker1TwitterLink"); }
		}

		///<summary>
		/// Stanowisko: Stanowisko prelegenta 1
		///</summary>
		[ImplementPropertyType("speaker1WorkPosition")]
		public IHtmlString Speaker1WorkPosition
		{
			get { return this.GetPropertyValue<IHtmlString>("speaker1WorkPosition"); }
		}

		///<summary>
		/// Opis: Opis prelegenta 2
		///</summary>
		[ImplementPropertyType("speaker2Desc")]
		public IHtmlString Speaker2Desc
		{
			get { return this.GetPropertyValue<IHtmlString>("speaker2Desc"); }
		}

		///<summary>
		/// Prelegent 2 link Facebook: Link do facebook'a prelegenta 2
		///</summary>
		[ImplementPropertyType("speaker2FbLink")]
		public string Speaker2FbLink
		{
			get { return this.GetPropertyValue<string>("speaker2FbLink"); }
		}

		///<summary>
		/// Zdjęcie prelegenta 2: Zdjęcie prelegenta 2 450x450 [px]
		///</summary>
		[ImplementPropertyType("speaker2Img")]
		public object Speaker2Img
		{
			get { return this.GetPropertyValue("speaker2Img"); }
		}

		///<summary>
		/// Prelegent 2 link LinkedIn: Link do LinkedIn prelegenta 2
		///</summary>
		[ImplementPropertyType("speaker2LinkedInLink")]
		public string Speaker2LinkedInLink
		{
			get { return this.GetPropertyValue<string>("speaker2LinkedInLink"); }
		}

		///<summary>
		/// Imię i Nazwisko: Imię i Nazwisko prelegenta 2
		///</summary>
		[ImplementPropertyType("speaker2Name")]
		public IHtmlString Speaker2Name
		{
			get { return this.GetPropertyValue<IHtmlString>("speaker2Name"); }
		}

		///<summary>
		/// Prelegent 2 link Twitter: Link do twittera prelegenta 2
		///</summary>
		[ImplementPropertyType("speaker2TwitterLink")]
		public string Speaker2TwitterLink
		{
			get { return this.GetPropertyValue<string>("speaker2TwitterLink"); }
		}

		///<summary>
		/// Stanowisko: Stanowisko prelegenta 2
		///</summary>
		[ImplementPropertyType("speaker2WorkPosition")]
		public IHtmlString Speaker2WorkPosition
		{
			get { return this.GetPropertyValue<IHtmlString>("speaker2WorkPosition"); }
		}

		///<summary>
		/// Opis: Opis prelegenta 3
		///</summary>
		[ImplementPropertyType("speaker3Desc")]
		public IHtmlString Speaker3Desc
		{
			get { return this.GetPropertyValue<IHtmlString>("speaker3Desc"); }
		}

		///<summary>
		/// Prelegent 3 link Facebook: Link do facebook'a prelegenta 3
		///</summary>
		[ImplementPropertyType("speaker3FbLink")]
		public string Speaker3FbLink
		{
			get { return this.GetPropertyValue<string>("speaker3FbLink"); }
		}

		///<summary>
		/// Zdjęcie prelegenta 3: Zdjęcie prelegenta 3 450x450 [px]
		///</summary>
		[ImplementPropertyType("speaker3Img")]
		public object Speaker3Img
		{
			get { return this.GetPropertyValue("speaker3Img"); }
		}

		///<summary>
		/// Prelegent 3 link LinkedIn: Link do LinkedIn prelegenta 3
		///</summary>
		[ImplementPropertyType("speaker3LinkedInLink")]
		public string Speaker3LinkedInLink
		{
			get { return this.GetPropertyValue<string>("speaker3LinkedInLink"); }
		}

		///<summary>
		/// Imię i Nazwisko: Imię i Nazwisko prelegenta 3
		///</summary>
		[ImplementPropertyType("speaker3Name")]
		public IHtmlString Speaker3Name
		{
			get { return this.GetPropertyValue<IHtmlString>("speaker3Name"); }
		}

		///<summary>
		/// Prelegent 3 link Twitter: Link do twittera prelegenta 3
		///</summary>
		[ImplementPropertyType("speaker3TwitterLink")]
		public string Speaker3TwitterLink
		{
			get { return this.GetPropertyValue<string>("speaker3TwitterLink"); }
		}

		///<summary>
		/// Stanowisko: Stanowisko prelegenta 3
		///</summary>
		[ImplementPropertyType("speaker3WorkPosition")]
		public IHtmlString Speaker3WorkPosition
		{
			get { return this.GetPropertyValue<IHtmlString>("speaker3WorkPosition"); }
		}

		///<summary>
		/// Kategoria: Kategoria aktualności
		///</summary>
		[ImplementPropertyType("typeDropdown")]
		public object TypeDropdown
		{
			get { return this.GetPropertyValue("typeDropdown"); }
		}

		///<summary>
		/// MaterialyDoPobrania: Materiały z wydarzenia do pobrania
		///</summary>
		[ImplementPropertyType("zipPackage")]
		public object ZipPackage
		{
			get { return this.GetPropertyValue("zipPackage"); }
		}
	}

	/// <summary>GaleriaSzczegoly</summary>
	[PublishedContentModel("galeriaSzczegoly")]
	public partial class GaleriaSzczegoly : Galeria
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "galeriaSzczegoly";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public GaleriaSzczegoly(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<GaleriaSzczegoly, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Data: Data wydarzenia, z którego pochodzi galeria
		///</summary>
		[ImplementPropertyType("galleryDate")]
		public string GalleryDate
		{
			get { return this.GetPropertyValue<string>("galleryDate"); }
		}

		///<summary>
		/// Opis galerii: Krótki opis wydarzenia, z którego pochodzi galeria
		///</summary>
		[ImplementPropertyType("galleryDesc")]
		public IHtmlString GalleryDesc
		{
			get { return this.GetPropertyValue<IHtmlString>("galleryDesc"); }
		}

		///<summary>
		/// Główne zdjęcie: Zdjęcie główne galerii wyświetlane na głównej podstronie GALERIA
		///</summary>
		[ImplementPropertyType("galleryMainImg")]
		public object GalleryMainImg
		{
			get { return this.GetPropertyValue("galleryMainImg"); }
		}

		///<summary>
		/// Zdjęcia: Zdjęcia w galerii
		///</summary>
		[ImplementPropertyType("galleryPhotos")]
		public string GalleryPhotos
		{
			get { return this.GetPropertyValue<string>("galleryPhotos"); }
		}

		///<summary>
		/// Nazwa galerii: Nazwa wydarzenia, z którego pochodzi galeria
		///</summary>
		[ImplementPropertyType("galleryTitle")]
		public string GalleryTitle
		{
			get { return this.GetPropertyValue<string>("galleryTitle"); }
		}
	}

	/// <summary>ProjektySzczegoly</summary>
	[PublishedContentModel("projektySzczegoly")]
	public partial class ProjektySzczegoly : Projekty
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "projektySzczegoly";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ProjektySzczegoly(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ProjektySzczegoly, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Projekt Banner: Baner z np. screenem aplikacji 1920x500 [px]
		///</summary>
		[ImplementPropertyType("projectBigImg")]
		public object ProjectBigImg
		{
			get { return this.GetPropertyValue("projectBigImg"); }
		}

		///<summary>
		/// Project "Co To?": Projekt - kolumna "Co to takiego?"
		///</summary>
		[ImplementPropertyType("projectCoTo")]
		public IHtmlString ProjectCoTo
		{
			get { return this.GetPropertyValue<IHtmlString>("projectCoTo"); }
		}

		///<summary>
		/// Project "Dla Kogo?": Projekt - kolumna "Dla kogo?"
		///</summary>
		[ImplementPropertyType("projectDlaKogo")]
		public IHtmlString ProjectDlaKogo
		{
			get { return this.GetPropertyValue<IHtmlString>("projectDlaKogo"); }
		}

		///<summary>
		/// Projekt w liczbach1: Informacje np. o ilości osób jakie wzięły udział w projekcie
		///</summary>
		[ImplementPropertyType("projectFirstDetails")]
		public string ProjectFirstDetails
		{
			get { return this.GetPropertyValue<string>("projectFirstDetails"); }
		}

		///<summary>
		/// Projekt w liczbach1 opis: Opis do pierwszej szczegółowej informacji
		///</summary>
		[ImplementPropertyType("projectFirstDetailsDesc")]
		public string ProjectFirstDetailsDesc
		{
			get { return this.GetPropertyValue<string>("projectFirstDetailsDesc"); }
		}

		///<summary>
		/// Projekt Logo: Logo aplikacji 300x300 [px]
		///</summary>
		[ImplementPropertyType("projectLogo")]
		public object ProjectLogo
		{
			get { return this.GetPropertyValue("projectLogo"); }
		}

		///<summary>
		/// Projekt Grafika: Grafika poszczególnego projektu na głównej stronie projektów 600x450 [px]
		///</summary>
		[ImplementPropertyType("projectMainImg")]
		public object ProjectMainImg
		{
			get { return this.GetPropertyValue("projectMainImg"); }
		}

		///<summary>
		/// Nazwa Projektu: Pełna nazwa projektu wyświetlana w szczegółach projektu
		///</summary>
		[ImplementPropertyType("projectMainTitle")]
		public IHtmlString ProjectMainTitle
		{
			get { return this.GetPropertyValue<IHtmlString>("projectMainTitle"); }
		}

		///<summary>
		/// Project "Po Co?": Projekt - kolumna "Po co?"
		///</summary>
		[ImplementPropertyType("projectPoco")]
		public IHtmlString ProjectPoco
		{
			get { return this.GetPropertyValue<IHtmlString>("projectPoco"); }
		}

		///<summary>
		/// Projekt Screen: Mockup ze screenem aplikacji/systemu 800x282 [px]
		///</summary>
		[ImplementPropertyType("projectScreen")]
		public object ProjectScreen
		{
			get { return this.GetPropertyValue("projectScreen"); }
		}

		///<summary>
		/// Projekt w liczbach2: Informacje np. o ilości osób jakie wzięły udział projekcie
		///</summary>
		[ImplementPropertyType("projectSecondDetails")]
		public string ProjectSecondDetails
		{
			get { return this.GetPropertyValue<string>("projectSecondDetails"); }
		}

		///<summary>
		/// Projekt w liczbach2 opis: Opis do drugiej szczegółowej informacji
		///</summary>
		[ImplementPropertyType("projectSecondDetailsDesc")]
		public string ProjectSecondDetailsDesc
		{
			get { return this.GetPropertyValue<string>("projectSecondDetailsDesc"); }
		}

		///<summary>
		/// Krótki opis: Krótki opis projektu na stronie projektów
		///</summary>
		[ImplementPropertyType("projectShortDesc")]
		public IHtmlString ProjectShortDesc
		{
			get { return this.GetPropertyValue<IHtmlString>("projectShortDesc"); }
		}

		///<summary>
		/// Projekt w liczbach3: Informacje np. o ilości osób jakie wzięły udział w projekcie
		///</summary>
		[ImplementPropertyType("projectThirdDetails")]
		public string ProjectThirdDetails
		{
			get { return this.GetPropertyValue<string>("projectThirdDetails"); }
		}

		///<summary>
		/// Projekt w liczbach3 opis: Opis do trzeciej szczegółowej informacji
		///</summary>
		[ImplementPropertyType("projectThirdDetailsDesc")]
		public string ProjectThirdDetailsDesc
		{
			get { return this.GetPropertyValue<string>("projectThirdDetailsDesc"); }
		}

		///<summary>
		/// Nazwa Projektu: Nazwa projektu na stronie projektów
		///</summary>
		[ImplementPropertyType("projectTitle")]
		public string ProjectTitle
		{
			get { return this.GetPropertyValue<string>("projectTitle"); }
		}
	}

	/// <summary>Layout</summary>
	[PublishedContentModel("layout")]
	public partial class Layout : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "layout";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Layout(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Layout, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Banner1Link: Podlinkowanie banera: np. do galerii, do innej strony, do wydarzenia na FB
		///</summary>
		[ImplementPropertyType("banner1Link")]
		public string Banner1Link
		{
			get { return this.GetPropertyValue<string>("banner1Link"); }
		}

		///<summary>
		/// Banner2Link: Podlinkowanie banera: np. do galerii, do innej strony, do wydarzenia na FB
		///</summary>
		[ImplementPropertyType("banner2Link")]
		public string Banner2Link
		{
			get { return this.GetPropertyValue<string>("banner2Link"); }
		}

		///<summary>
		/// Banner3Link: Podlinkowanie banera: np. do galerii, do innej strony, do wydarzenia na FB
		///</summary>
		[ImplementPropertyType("banner3Link")]
		public string Banner3Link
		{
			get { return this.GetPropertyValue<string>("banner3Link"); }
		}

		///<summary>
		/// Baner 1: Baner1 image
		///</summary>
		[ImplementPropertyType("bannerSlideImage1")]
		public object BannerSlideImage1
		{
			get { return this.GetPropertyValue("bannerSlideImage1"); }
		}

		///<summary>
		/// Baner 2: Baner 2
		///</summary>
		[ImplementPropertyType("bannerSlideImage2")]
		public object BannerSlideImage2
		{
			get { return this.GetPropertyValue("bannerSlideImage2"); }
		}

		///<summary>
		/// Baner 3: Baner 3
		///</summary>
		[ImplementPropertyType("bannerSlideImage3")]
		public object BannerSlideImage3
		{
			get { return this.GetPropertyValue("bannerSlideImage3"); }
		}

		///<summary>
		/// Banner 1 tekst: Tekst główny
		///</summary>
		[ImplementPropertyType("bannerText1")]
		public string BannerText1
		{
			get { return this.GetPropertyValue<string>("bannerText1"); }
		}

		///<summary>
		/// Banner 1 tekst 2: Tekst mniejszy
		///</summary>
		[ImplementPropertyType("bannerText1Inner")]
		public string BannerText1Inner
		{
			get { return this.GetPropertyValue<string>("bannerText1Inner"); }
		}

		///<summary>
		/// Banner 2 tekst: Tekst główny
		///</summary>
		[ImplementPropertyType("bannerText2")]
		public string BannerText2
		{
			get { return this.GetPropertyValue<string>("bannerText2"); }
		}

		///<summary>
		/// Banner 2 tekst 2: Tekst mniejszy
		///</summary>
		[ImplementPropertyType("bannerText2Inner")]
		public string BannerText2Inner
		{
			get { return this.GetPropertyValue<string>("bannerText2Inner"); }
		}

		///<summary>
		/// Banner 3 tekst: Tekst główny
		///</summary>
		[ImplementPropertyType("bannerText3")]
		public string BannerText3
		{
			get { return this.GetPropertyValue<string>("bannerText3"); }
		}

		///<summary>
		/// Banner 3 tekst 2: Tekst mniejszy
		///</summary>
		[ImplementPropertyType("bannerText3Inner")]
		public string BannerText3Inner
		{
			get { return this.GetPropertyValue<string>("bannerText3Inner"); }
		}
	}

	/// <summary>KontaktNode</summary>
	[PublishedContentModel("kontaktNode")]
	public partial class KontaktNode : Kontakt
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "kontaktNode";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public KontaktNode(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<KontaktNode, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Kontakt Link Facebook: Link do Fb kontaktu (opcjonalnie do Fb Resetowego)
		///</summary>
		[ImplementPropertyType("contactFbLink")]
		public string ContactFbLink
		{
			get { return this.GetPropertyValue<string>("contactFbLink"); }
		}

		///<summary>
		/// Zdjęcie kontaktu: Zdjęcie kontaktu 600x700 [px]
		///</summary>
		[ImplementPropertyType("contactImg")]
		public object ContactImg
		{
			get { return this.GetPropertyValue("contactImg"); }
		}

		///<summary>
		/// Kontakt Link LinkedIn: Link do LinkedIn kontaktu
		///</summary>
		[ImplementPropertyType("contactLinkedInLink")]
		public string ContactLinkedInLink
		{
			get { return this.GetPropertyValue<string>("contactLinkedInLink"); }
		}

		///<summary>
		/// Mail: Mail kontaktowy
		///</summary>
		[ImplementPropertyType("contactMail")]
		public string ContactMail
		{
			get { return this.GetPropertyValue<string>("contactMail"); }
		}

		///<summary>
		/// Imię i Nazwisko: Imię, Nazwisko, stopień naukowy kontaktu np. dr inż. Jan Kowalski
		///</summary>
		[ImplementPropertyType("contactName")]
		public string ContactName
		{
			get { return this.GetPropertyValue<string>("contactName"); }
		}

		///<summary>
		/// Rola: Rola pełniona w Resecie
		///</summary>
		[ImplementPropertyType("contactRole")]
		public string ContactRole
		{
			get { return this.GetPropertyValue<string>("contactRole"); }
		}

		///<summary>
		/// Kontakt Link Twitter: Link do Twittera kontaktu (lub do Twiitera Resetowego)
		///</summary>
		[ImplementPropertyType("contactTwitterLink")]
		public string ContactTwitterLink
		{
			get { return this.GetPropertyValue<string>("contactTwitterLink"); }
		}

		///<summary>
		/// Typ Kontaktu: Typ Kontaktu -  zarząd lub członek Koła
		///</summary>
		[ImplementPropertyType("contactType")]
		public object ContactType
		{
			get { return this.GetPropertyValue("contactType"); }
		}
	}

	/// <summary>Oferty Pracy</summary>
	[PublishedContentModel("ofertyPracy")]
	public partial class OfertyPracy : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "ofertyPracy";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public OfertyPracy(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<OfertyPracy, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>OfertyPracyNode</summary>
	[PublishedContentModel("ofertyPracyNode")]
	public partial class OfertyPracyNode : OfertyPracy
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "ofertyPracyNode";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public OfertyPracyNode(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<OfertyPracyNode, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// OfertaPracyFirma: Nazwa firmy, od której pochodzi oferta pracy
		///</summary>
		[ImplementPropertyType("JobOfferFirm")]
		public string JobOfferFirm
		{
			get { return this.GetPropertyValue<string>("JobOfferFirm"); }
		}

		///<summary>
		/// OfertaPracyImg: Oferta Pracy - grafika, zdjęcie [rozmiar dowolny]
		///</summary>
		[ImplementPropertyType("JobOfferImg")]
		public object JobOfferImg
		{
			get { return this.GetPropertyValue("JobOfferImg"); }
		}

		///<summary>
		/// OfertaPracyInfografika: Główna infografika oferty pracy 500x300 [px]
		///</summary>
		[ImplementPropertyType("JobOfferMainImg")]
		public object JobOfferMainImg
		{
			get { return this.GetPropertyValue("JobOfferMainImg"); }
		}

		///<summary>
		/// OfertaPracyStanowisko: Nazwa stanowiska, którego dotyczy ogłoszenie
		///</summary>
		[ImplementPropertyType("JobOfferPosition")]
		public string JobOfferPosition
		{
			get { return this.GetPropertyValue<string>("JobOfferPosition"); }
		}

		///<summary>
		/// OfertaPracyOpis: Krótki opis ogłoszenia
		///</summary>
		[ImplementPropertyType("JobOfferShortDesc")]
		public IHtmlString JobOfferShortDesc
		{
			get { return this.GetPropertyValue<IHtmlString>("JobOfferShortDesc"); }
		}
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public object UmbracoBytes
		{
			get { return this.GetPropertyValue("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public object UmbracoExtension
		{
			get { return this.GetPropertyValue("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public object UmbracoHeight
		{
			get { return this.GetPropertyValue("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public object UmbracoWidth
		{
			get { return this.GetPropertyValue("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public object UmbracoBytes
		{
			get { return this.GetPropertyValue("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public object UmbracoExtension
		{
			get { return this.GetPropertyValue("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public object UmbracoFile
		{
			get { return this.GetPropertyValue("umbracoFile"); }
		}
	}

	/// <summary>Baner</summary>
	[PublishedContentModel("baner")]
	public partial class Baner : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "baner";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Baner(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Baner, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public object UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public object UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public object UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public object UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public object UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public object UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}
