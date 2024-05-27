using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lesson06_1.Models;

namespace Lesson06_1.Controllers
{
    public class TDTDSongController : Controller
    {
        public static List<TDTDSong> TDTDSongs = new List<TDTDSong>()
        {
            new TDTDSong{ ID = 1 ,TDTDTitle = "Jotaro Theme", TDTDAuthor = "Jotaro" , TDTDArtist = "Kujo Jotaro", TDTDYearRelease = 2020},
            new TDTDSong{ ID = 2 ,TDTDTitle = "Giorno Theme", TDTDAuthor = "Giorno",TDTDArtist = "Giorno Giovanna", TDTDYearRelease = 2020},
        };
        // GET: TDTDSong
        public ActionResult TDTDIndex()
        {
            return View(TDTDSongs);
        }
        public ActionResult TDTDCreate()
        {
            var TDTDsong = new TDTDSong();
            return View(TDTDsong);
        }
        [HttpPost]
        public ActionResult TDTDCreate(TDTDSong tDTDSong)
        {
            if(!ModelState.IsValid) // lỗi
            {
                return View(tDTDSong);
            }
            TDTDSongs.Add(tDTDSong);
            return RedirectToAction("TDTDIndex");
        }
    }
}