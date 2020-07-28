using System.Threading.Tasks;
using DataAccess.MaritalStatuses;

namespace DataAccess.Implementation.MaritalStatuses
{
    public class MaritalStatusStorage : IMaritalStatusStorage
    {
        private readonly IMaritalStatusTableCreator _maritalStatusTableCreator;
        private readonly IMaritalStatusCodingTableCreator _maritalStatusCodingTableCreator;
        private readonly IMaritalStatusRecordReader _maritalStatusRecordReader;
        private readonly IMaritalStatusRecordWriter _maritalStatusRecordWriter;
        private readonly IMaritalStatusCodingRecordWriter _maritalStatusCodingRecordWriter;

        public MaritalStatusStorage(
            IMaritalStatusTableCreator maritalStatusTableCreator,
            IMaritalStatusCodingTableCreator maritalStatusCodingTableCreator,
            IMaritalStatusRecordReader maritalStatusRecordReader,
            IMaritalStatusRecordWriter maritalStatusRecordWriter,
            IMaritalStatusCodingRecordWriter maritalStatusCodingRecordWriter)
        {
            _maritalStatusTableCreator = maritalStatusTableCreator;
            _maritalStatusCodingTableCreator = maritalStatusCodingTableCreator;
            _maritalStatusRecordReader = maritalStatusRecordReader;
            _maritalStatusRecordWriter = maritalStatusRecordWriter;
            _maritalStatusCodingRecordWriter = maritalStatusCodingRecordWriter;
        }

        public async Task InitAsync()
        {
            await _maritalStatusTableCreator.CreateIfNotExistsAsync();
            await _maritalStatusCodingTableCreator.CreateIfNotExistsAsync();
            await InitDataAsync();
        }

        private async Task InitDataAsync()
        {
            if (await _maritalStatusRecordReader.CountAsync < 1)
            {
                var defaults = MaritalStatusDefaults.Defaults;

                foreach (var status in defaults)
                {
                    var pkStatus = await _maritalStatusRecordWriter.WriteAsync(status);

                    foreach (var coding in status.Coding)
                    {
                        await _maritalStatusCodingRecordWriter.WriteAsync(coding, pkStatus);
                    }
                }
            }
        }
    }
}