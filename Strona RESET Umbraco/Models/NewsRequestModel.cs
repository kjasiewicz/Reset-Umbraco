namespace Strona_RESET_Umbraco.Models
{
    public class NewsRequestModel
    {
        public int Page { get; set; }
        public int PageSize
        {
            get
            {
                //Const value
                return 5;
            }
        }
    }
}