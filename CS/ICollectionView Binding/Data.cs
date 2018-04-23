using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Data;

namespace ICollectionView_Binding {
    public class ViewModel {
        ICollectionView data;
        public ICollectionView Data {
            get {
                if (data == null) {
                    List<TestData> list = new List<TestData>();
                    for (int i = 0; i < 100; i++) {
                        list.Add(new TestData() { Number1 = i, Number2 = i * 10, Text1 = "row " + i, Text2 = "ROW " + i });
                    }
                    data = new CollectionViewSource { Source = list }.View;
                }
                return data;
            }
        }
    }
    public class TestData {
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public string Text1 { get; set; }
        public string Text2 { get; set; }
    }
}
