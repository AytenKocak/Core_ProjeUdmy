using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Abstract
{
   public interface IWriterMessageService:IGenericService<WriterMessage>
    {
        List<WriterMessage> GetListSenderMessager(string p);
        List<WriterMessage> GetListRecieverMessage(string p);
    }
}
