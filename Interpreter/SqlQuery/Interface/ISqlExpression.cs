using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterDesignPattern
{
    public interface ISqlExpression
    {
        void Interpret(SqlCommand command);
    }
}
