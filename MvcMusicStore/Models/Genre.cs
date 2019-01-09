
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class Genre
    {
        public int GenreId { get; set; }//自动属性
        [DisplayName("专辑")]
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Album> Albums { get; set; }
    }
}