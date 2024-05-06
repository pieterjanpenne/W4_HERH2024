using Assignment.Core.Helpers;
using Assignment.Repository.Context;
using Assignment.Repository.Models;
using AutoMapper;

namespace Assignment.Repository.Repositories;

public class MenuRepository: BaseRepository<RestoContext, Menu>
{
    private readonly IMapper _mapper;
    private ISortHelper<Menu> _sortHelper;

    #region Ctor
    public MenuRepository(RestoContext dbContext, IMapper mapper, ISortHelper<Menu> sortHelper) : base(dbContext)
    {
            _mapper = mapper;
            _sortHelper = sortHelper;
    }
    #endregion

    public PagedList<Menu> GetAll(QueryStringParameters parameters)
    {
        IQueryable<Menu> menus;

        //if (parameters is MenuParameters ownParameters)
        //    menus = FindByCondition(o => o.BirthDate.Value <= ownParameters.MaxYearOfBirth);
        //else
            menus = FindAll();

        var sortedMenus = _sortHelper.ApplySort(ref menus, parameters.OrderBy);

        var repositoryMenus = PagedList<Menu>.ToPagedList(sortedMenus, parameters.PageNumber, parameters.PageSize);
        var domainMenus = _mapper.Map<PagedList<Menu>>(repositoryMenus);

        //TODO: solve copy
        domainMenus.TotalCount = repositoryMenus.TotalCount;
        domainMenus.CurrentPage = repositoryMenus.CurrentPage;
        domainMenus.TotalPages = repositoryMenus.TotalPages;
        domainMenus.PageSize = repositoryMenus.PageSize;

        return domainMenus;
    }
}
