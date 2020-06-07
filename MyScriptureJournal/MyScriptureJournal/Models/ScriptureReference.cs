using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyScriptureJournal.Models
{
    public class ScriptureReference
    {
        [Key]
        public int ID { get; set; }

        [RegularExpression(@"^(([\d]\s+[A-Z])|[A-Z])[a-z]+(([\s][&][\s]|(\sand\s))[A-Z][a-z]*)?$")]
        [Required]
        public string Book { get; set; }

        [RegularExpression(@"^([\d]{0,3}|null)$")]
        public int? Chapter { get; set; }

        [RegularExpression(@"^([\d]{0,3}|null)$")]
        public int? RefStart { get; set; }

        [RegularExpression(@"^([\d]{0,3}|null)$")]
        public int? RefEnd { get; set; }

    }
}
