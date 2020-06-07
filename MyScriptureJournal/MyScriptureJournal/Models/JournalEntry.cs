using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.Mvc;

namespace MyScriptureJournal.Models
{
    public class JournalEntry
    {
        public JournalEntry() 
        {

        }

        [Key]
        public int ID { get; set; }

        [Required]
        public string Note { get; set; }

        [Required, Display(Name = "Date Created")]
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }

        [Display(Name = "Last Edited")]
        [DataType(DataType.Date)]
        public DateTime EditDate { get; set; }

        [Required]
        public int ScriptureReferenceID { get; set; }

        [Required]
        public ScriptureReference ScriptureRef { get; set; }

    }
}
