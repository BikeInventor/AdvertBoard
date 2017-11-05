
namespace DataAccessLayer.Entities
{
    /// <summary>
    /// Роль пользователя.
    /// </summary>
    public class Role : EntityBase<short>
    {
        /// <summary>
        /// Наименование роли.
        /// </summary>
        public string RoleName { get; set; }
    }
}
