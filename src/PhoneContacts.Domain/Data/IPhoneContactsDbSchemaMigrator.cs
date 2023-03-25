using System.Threading.Tasks;

namespace PhoneContacts.Data;

public interface IPhoneContactsDbSchemaMigrator
{
    Task MigrateAsync();
}
