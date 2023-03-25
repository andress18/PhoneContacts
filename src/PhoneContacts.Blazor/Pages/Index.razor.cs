using Blazorise.DataGrid;
using PhoneContacts.Contacts;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Volo.Abp.Application.Dtos;

namespace PhoneContacts.Blazor.Pages;

public partial class Index
{
    protected override Task UpdateGetListInputAsync()
    {
        if (GetListInput is ISortedResultRequest sortedResultRequestInput)
        {
            sortedResultRequestInput.Sorting = CurrentSorting;
        }

        if (GetListInput is IPagedResultRequest pagedResultRequestInput)
        {
            pagedResultRequestInput.SkipCount = (CurrentPage - 1) * PageSize;
        }

        if (GetListInput is ILimitedResultRequest limitedResultRequestInput)
        {
            limitedResultRequestInput.MaxResultCount = PageSize;

        }
        return Task.CompletedTask;
    }

    protected override Task OnDataGridReadAsync(DataGridReadDataEventArgs<ContactDto> e)
    {
        
        var name = e.Columns.FirstOrDefault(c => c.SearchValue != null && c.Field == "Name");
        if (name != null) GetListInput.Name = name.SearchValue.ToString();

        return base.OnDataGridReadAsync(e);
    }
}
