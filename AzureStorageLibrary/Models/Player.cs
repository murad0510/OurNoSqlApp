using Microsoft.Azure.Cosmos.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureStorageLibrary.Models
{
    public class Player : TableEntity
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public decimal Salary { get; set; }
        public int Score { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
