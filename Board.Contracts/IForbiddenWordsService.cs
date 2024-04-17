using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board.Contracts
{
    public interface IForbiddenWordsService
    {
        string[] GetForbiddenWords();

    }
}
