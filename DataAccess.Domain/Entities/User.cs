using System.Collections.Generic;

namespace DataAccessLayer.Entities
{
    /// <summary>
    /// Пользователь системы.
    /// </summary>
    public class User : EntityBase<int>
    {
        /// <summary>
        /// Имя пользователя.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Пароль.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Перечень ролей пользователя.
        /// </summary>
        public virtual ICollection<Role> Roles { get; set; }

        /// <summary>
        /// Объявления, размещённые пользователем.
        /// </summary>
        public virtual ICollection<Advert> Adverts { get; set; }
    }
}
