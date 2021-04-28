using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Класс Result содержит свойства флаг Status и сообщение об ошибке если это необходимо
*/

namespace HomeTask4
{
    public class Result
    {
        public bool Status { get; set; }

        public string Message { get; set; }
    }
}
