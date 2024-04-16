using Lab2_BTTL_2_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2_BTTL_2_1.Controllers
{
    public class TDTD_HomeController : Controller
    {
        private static List<Song> songs = new List<Song>
        {
            new Song { Id = 1, Title = "Eternxlkz - SLAY!", FilePath = "/Content/Eternxlkz - SLAY! (Official Audio).mp3" },
            new Song { Id = 2, Title = "Eternxlkz  ENOUGH Official Audio", FilePath = "/Content/Eternxlkz  ENOUGH Official Audio.mp3" },
            new Song { Id = 3, Title = "Eternxlkz  TOKYO DRIFT FUNK Official Audio", FilePath = "/Content/Eternxlkz  TOKYO DRIFT FUNK Official Audio.mp3" },
            new Song { Id = 4, Title = "Eternxlkz  JUJALARIM FUNK Official Audio", FilePath = "/Content/Eternxlkz  JUJALARIM FUNK Official Audio.mp3" },
            new Song { Id = 5, Title = "Eternxlkz  BRODYAGA FUNK Official Audio", FilePath = "/Content/Eternxlkz  BRODYAGA FUNK Official Audio.mp3" }
        };
        // GET: TDTD_Home
        public ActionResult Index()
        {
            return View(songs);
        }
        public ActionResult Detail(int id)
        {
            var song = songs.Find(s => s.Id == id);
            return View(song);
        }

        public ActionResult Download(int id)
        {
            var song = songs.Find(s => s.Id == id);
            if (song != null)
            {
                return File(song.FilePath, "audio/mpeg", song.Title + ".mp3");
            }
            return HttpNotFound();
        }
    }
}