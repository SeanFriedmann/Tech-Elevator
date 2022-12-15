namespace CatCards.Models
{
    public class CatCard
    {
        public int CatCardId { get; set; }

        public string CatFact { get; set; }

        public string ImgUrl { get; set; }

        public string Caption { get; set; }

        //public CatCard(int catCardId, string catFact, string imageUrl, string caption)
        //{
        //    CatCardId = catCardId;
        //    CatFact = catFact;
        //    ImgUrl = imageUrl;
        //    Caption = caption;
        //}
    }

}
