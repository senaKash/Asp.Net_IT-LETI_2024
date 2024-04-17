using Board.Application.AppData.Posts.Services;
using Board.Contracts.Posts;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;



namespace Board.Host.Api.Controllers
{
    /// <summary>
    /// Контроллер для работы с объявлениями
    /// </summary>
    [ApiController]
    [Route(template: "[controller]")]
    public class PostsController : ControllerBase
    {

        private readonly ILogger<PostsController> _logger;

        private readonly IPostService _postService;

        /// <summary>
        ///  Инициализирует экземпляр <see cref="PostsController"/>
        /// </summary>
        /// <param name="logger">Сервис логирования</param>
        /// <param name="postService">Сервисы по работе с объявлениями</param>
        public PostsController(ILogger<PostsController> logger, IPostService postService)
        {

            _logger = logger;
            _postService = postService;
        }

        /// <summary>
        /// Запрос объявления
        /// </summary>
        /// <returns></returns>
        [HttpGet(template:"get-post")]
        public async Task<IActionResult> Get()
        {
            //_logger.LogInformation(message: $"{nameof(PostsController)} ");
            //LogWarning
            //LogCritical 
            //LogDebug
            _logger.LogInformation(message: $"Запрос обновлений ");

            return await Task.Run(Ok); 
        }


        /// <summary>
        /// Сохраняет новое объявление
        /// </summary>
        /// <param name="dto">Модель создания объявления</param>
        /// <returns>Модель созданного объявления</returns>
        [HttpPost]
        public async Task<IActionResult> CreatePost([FromBody] CreatePostDto dto, CancellationToken cancellation)
        {
            _logger.LogInformation(message: $"{JsonConvert.SerializeObject(dto)}");

            //var result:Task < CreatePostDto > = await _postService.AddPost(dto, cancellation);
            var result = await _postService.AddPost(dto, cancellation);

            return await Task.Run(function:() => Created(uri:string.Empty, result));
        }

    }
}
 