using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProtOJ.Models;
using ProtOJ.Data;

namespace ProtOJ.Pages.Sessions
{
    public class IndexModel : PageModel
    {
        private readonly ProtOJContext _context;

        public IndexModel(ProtOJContext context)
        {
            _context = context;
        }

        public IList<Session> Session { get;set; }

        public async Task OnGetAsync()
        {
            Session = await _context.Sessions.ToListAsync();
        }
    }
}
