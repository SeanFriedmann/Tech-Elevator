using System.Collections.Generic;
using CatCards.DAO;
using CatCards.Models;
using CatCards.Services;
using Microsoft.AspNetCore.Mvc;

namespace CatCards.Controllers
{
    [Route("/api/cards")]
    [ApiController]
    public class CatController : ControllerBase
    {
        private readonly ICatCardDao cardDao;
        private readonly ICatFactService catFactService;
        private readonly ICatPicService catPicService;

        public CatController(ICatCardDao _cardDao, ICatFactService _catFact, ICatPicService _catPic)
        {
            catFactService = _catFact;
            catPicService = _catPic;
            cardDao = _cardDao;
        }

        [HttpGet()]
        public List<CatCard> GetCatCards()
        {
            return cardDao.GetAllCards();
        }

        [HttpGet("{id}")]
        public ActionResult<CatCard> GetCatCardById(int id)
        {
            CatCard catcard = cardDao.GetCard(id);
            if (catcard != null)
            {
                return catcard;
            }
            else
            {
                return NotFound();
            }
        }
        
        [HttpGet("random")]
        public ActionResult<CatCard> GetRandomCatCard()
        {
            CatCard catCard = new CatCard();
            catCard.CatFact = catFactService.GetFact().Text;
            catCard.ImgUrl = catPicService.GetPic().File;
            return catCard;


          //  catFact = catFact.Text;
        }



       [HttpPost()]
       public ActionResult<CatCard> AddCatCard(CatCard cardToSave)
        {
            CatCard newCard = cardDao.SaveCard(cardToSave);
            return newCard;
        }

        [HttpPut("{id}")]
        public ActionResult<CatCard> UpdateCatCard(CatCard updatedCatCard)
        {
            CatCard existingCard = cardDao.GetCard(updatedCatCard.CatCardId);
            if (existingCard == null)
            {
                return NotFound();
            }
            else
            {
                bool result = cardDao.UpdateCard(updatedCatCard);
                return StatusCode(201);
            }

        }

        [HttpDelete("{id}")] // /reservations/:id 
        public ActionResult DeleteCatCard(int id) //send back a untyped ActionResult since I will never be sending a reservation back
        {
            CatCard existingCatCard = cardDao.GetCard(id);
            if (existingCatCard == null) //if the reservation doesn't exist 
            {
                return NotFound(); //404
            }

            bool result = cardDao.RemoveCard(id);

            if (result) //if true (thing was deleted)
            {
                return NoContent(); //return 204 No Content 
            }
            else
            {
                return StatusCode(500);
            }


        }

    }
}
