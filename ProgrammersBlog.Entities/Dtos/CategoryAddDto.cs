using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Entities.Dtos
{
    public class CategoryAddDto
    {
        [DisplayName("Kategori Adı")]
        [Required(ErrorMessage ="{0} boş geçilmemelidir!")]//{0} => display name de ne varsa o geliyor
        [MaxLength(70,ErrorMessage ="{0} {1} karakterden büyük olmamalıdır!")]//{1} yerinede 70 gelecek
        [MinLength(3,ErrorMessage = "{0} {1} karakterden küçük olmamalıdır!")]//{1} yerine 3 gelecek
        public string Name { get; set; }
        [DisplayName("Kategori Açıklaması")]
        [MaxLength(500, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır!")]//{1} yerinede 70 gelecek
        [MinLength(3, ErrorMessage = "{0} {1} karakterden küçük olmamalıdır!")]//{1} yerine 3 gelecek
        public string Description { get; set; }
        [DisplayName("Kategori Özel Not Alanı")]
        [MaxLength(500, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır!")]//{1} yerinede 70 gelecek
        [MinLength(3, ErrorMessage = "{0} {1} karakterden küçük olmamalıdır!")]//{1} yerine 3 gelecek
        public string Note { get; set; }
        [DisplayName("Aktif Mi?")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir!")]//{0} => display name de ne varsa o geliyor
        public bool IsActive { get; set; }
    }
}
