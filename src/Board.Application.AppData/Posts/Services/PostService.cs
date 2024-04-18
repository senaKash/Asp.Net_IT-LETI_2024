using Board.Application.AppData.Posts.Services;
using Board.Contracts.Posts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board.Application.AppData.Posts.Services
{
    ///<inheritdoc />
    public class PostService : IPostService
    {

        ///<inheritdoc />
        public async Task<CreatePostDto> AddPost(CreatePostDto dto, CancellationToken cancellationToken)
        {
           // throw new NotImplementedException();
            
              if(IsValid(dto)){
                //вызов репозитория для сохранения в бд
                //возврат результата
                return await Task.Run(function: () => dto, cancellationToken);
              }

            return new CreatePostDto();
             
        }

        
        private bool IsValid(CreatePostDto dto)
        {

           
           if (dto.CreationDate > DateTime.Now)
            {
                return false;
            }
            

            //логика валидации
            return true;
        }
        

    }
}
