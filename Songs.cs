using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Stream2nd.Models
{
    public class Songs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SongID { get; set; }
        [Required]
        [Display(Name = "Artist")]
        public string ArtistName { get; set; }
        [Required]
        [Display(Name = "Song Title")]
        public string Title { get; set; }
        
        [Display(Name = "Upload Song")]
        public string SongPath { get; set; }
        

    }
}