using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Wst.Model
{
    public class IEntity
    {
       [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public  virtual int ID { get; set; }
    }
}