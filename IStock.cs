using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstoquePOO
{
    public interface IStock
    {
        void GetInformationProduct();
        void AddInput();
        void AddOutput();
    }
}