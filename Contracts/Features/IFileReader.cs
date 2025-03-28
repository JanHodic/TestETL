using System;
namespace TestETL.Contracts.Features
{
    public interface IFileReader
    {
        public Task<ICollection<object>> ReadCSVFile();

        public Task<ICollection<object>> ReadXMLFile();
    }
}

