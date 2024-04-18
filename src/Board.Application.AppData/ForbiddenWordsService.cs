using Board.Contracts;

namespace Board.Application.AppData;
    public class ForbiddenWordsService : IForbiddenWordsService
    {

        public string[] GetForbiddenWords()
        {
            return new[] { "хаймарс" };
        }
        
        

    }

