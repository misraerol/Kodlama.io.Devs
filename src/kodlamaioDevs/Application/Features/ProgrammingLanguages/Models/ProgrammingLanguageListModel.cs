using Application.Features.ProgrammingLanguages.Dtos.ProgrammingLanguageDtos;
using Core.Persistence.Paging;

namespace Application.Features.ProgrammingLanguages.Models
{
    public class ProgrammingLanguageListModel:BasePageableModel
    {
        public IList<ProgrammingLanguageListDto> Items { get; set; }
    }
}
