using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NmpLesson6.Models;

namespace NmpLesson6.Controllers
{
    
    public class NmpSongController : Controller
    {

        private static List<NmpSong> nmpSongs = new List<NmpSong>
    {
            new NmpSong { Id = 221141, NmpTitle = "Nguyen Minh Phuong", NmpAuthor = "K22CNTT4", NmpArtist = "NTU", NmpYearRelease = 2020 },
            new NmpSong { Id = 1, NmpTitle = "Nguyen Minh Phuong", NmpAuthor = "K22CNTT4", NmpArtist = "NTU", NmpYearRelease = 2020 }
    };
        // GET: NmpSong
        /// <summary>
        /// Hien thi danh sach san pham
        /// Author: Nguyen Minh Phuong
        /// </summary>
        /// <returns></returns>
        public ActionResult NmpIndex()
        {
            return View();
        }

        /// GET : NmpCreate <summary>
        /// GET : NmpCreate
        /// Form them moi bai hat
        /// Author nguyen Minh Phuong
        /// </summary>
        /// <returns></returns>
        public ActionResult NmpCreate()
        {
            var nmpSong = new NmpSong();
            return View();
        }
    }
}