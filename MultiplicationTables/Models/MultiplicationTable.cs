using System;
using System.Collections.Generic;

namespace MultiplicationTables.Models

{
    public class MultiplyTable
    {
        public int multiplying { get; set; }
        public int result { get; set; }
    }

    public class MultiplyTableListVM
    {
        public int numberTable { get; set; }
        public IList<MultiplyTable> MultiplyTableList { get; set; }
    }
}
