using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NoteOrg.Core.Objects
{
    public class Workbook
    {
        [Key]
        public int WorkbookId { get; set; }

        public string WorkbookName { get; set; }
    }
}
