using CarnetDepenses.Models;

namespace CarnetDepenses.Services;

// Le ViewModel ne connait QUE cette interface.
public interface IDepenseRepository
{
    Task<List<Depense>> ListerAsync();
    Task AjouterAsync(Depense d);
    Task SupprimerAsync(Depense d);
}
