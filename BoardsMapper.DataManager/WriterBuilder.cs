using BoardsMapper.DataManager.Writers;
using System;

namespace BoardsMapper.DataManager
{
    public class WriterBuilder
    {
        public IWriter Build(WriteParameters parameters)
        {
            if (parameters is HtmlWriteParameters)
            {
                return new SimpleHtmlWriter();
            }
            else if(parameters is KmlWriteParameters)
            {
                return new KmlWriter();
            }
            else
            {
                return new KmlWriter();
            }
            
        }
    }
}
