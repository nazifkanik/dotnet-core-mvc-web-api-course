﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OOPTut.Core.Bazaar
{
    public class BazaarList
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(70)]
        public string Title { get; set; }
        [MaxLength(160)]
        public string Description { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        // Single Responsiblity ve DRY
        public static BazaarList Create(string title, string description, int creatorUserId)
        {
            return new BazaarList
            {
                Title = title,
                Description = description,
                CreatorUserId = creatorUserId,
                CreatedDate = DateTime.Now
            };
            // PascalCase : sinif isimleri, sinif properties, metod isimleri
            // camelCase: degiskenler, parametreler
            // kebap-case: html, css, js dosya isimleri. CSS'de id ve class isimleri
        }
    }
}
