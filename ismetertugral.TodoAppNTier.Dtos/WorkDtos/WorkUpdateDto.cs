using ismetertugral.TodoAppNTier.Dtos.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace ismetertugral.TodoAppNTier.Dtos.WorkDtos
{
    public class WorkUpdateDto : IDto
    {
        //[Range(1,int.MaxValue,ErrorMessage = "Id is required")]
        public int Id { get; set; }
        //[Required(ErrorMessage = "Definition is required")]
        public string Definition { get; set; }
        public bool IsCompleted { get; set; }
    }
}
