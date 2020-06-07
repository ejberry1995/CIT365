using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Pages.JournalEntries
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Data.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournal.Data.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<JournalEntry> JournalEntry { get;set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> bookQuery = from e in _context.JournalEntry
                                           orderby e.ScriptureRef.Book
                                           select e.ScriptureRef.Book;

            var entries = from e in _context.JournalEntry
                         select e;
            
            if (!string.IsNullOrEmpty(SearchString))
            {
                entries = entries.Where(s => s.Note.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(RefBook))
            { 
                entries = entries.Where(x => x.ScriptureRef.Book == RefBook);
            }

            ScriptureBooks = new SelectList(await bookQuery.Distinct().ToListAsync());
            
            switch(SortOption)
            {
                case "book":
                    entries = entries.OrderBy(x => x.ScriptureRef.Book);
                    break;
                case "creationDate":
                    entries = entries.OrderBy(x => x.CreationDate);
                    break;
                case "editDate":
                    entries = entries.OrderBy(x => x.EditDate);
                    break;
                default:
                    break;
            }
            
            JournalEntry = await entries
                .Include(x => x.ScriptureRef)
                .AsNoTracking()
                .ToListAsync();
        }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public SelectList ScriptureBooks { get; set; }

        [BindProperty(SupportsGet = true)]
        public string RefBook { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SortOption { get; set; }
    }
}
