using System.Collections.Generic;

namespace VelhIA_API.Application.Services
{
    public interface IService
    {
        G Convert<F, G>(F from);

        ICollection<G> ConvertCollection<F, G>(ICollection<F> from);
    }
}
