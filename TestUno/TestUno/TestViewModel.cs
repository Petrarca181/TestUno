using Microsoft.UI.Dispatching;
using System.Collections.ObjectModel;

namespace TestUno
{
    public partial class TestViewModel : ObservableObject
    {
        private readonly DispatcherQueue _dispatcherQueue = DispatcherQueue.GetForCurrentThread();

        [ObservableProperty]
        private ObservableCollection<TestModel> listSource = new();

        public TestViewModel()
        {
            populate();
        }

        private async void populate()
        {
            await Task.Delay(200);

            var tempList = await Task.Run(async () =>
            {
                var list = new List<TestModel>();

                for (int i = 0; i < 15; i++)
                {
                    list.Add(new TestModel());

                    await Task.Delay(20);
                }

                return list;
            });

            _dispatcherQueue.TryEnqueue(() =>
            {
                ListSource = new(tempList);
            });
        }
    }
}
