﻿using System.ComponentModel.DataAnnotations;

namespace GraphQLDemo_HotChocolate.Data
{
    public class Speaker
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Bio { get; set; }

        [StringLength(1000)]
        public virtual string WebSite { get; set; }
    }
}
