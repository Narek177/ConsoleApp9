using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2Module9
{
    public delegate void NotifyCollectionChanged(int sortDIrection);
    internal class LastNameContainer
    {
        private event NotifyCollectionChanged LastNameAdded;
        private List<string> LastNames { get; set; }
        public LastNameContainer()
        {
            LastNames = new List<string>();
            LastNameAdded += OnLastNameAdded;
        }

        /// <summary>
        /// Extual event handler
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void OnLastNameAdded(int sortDirection)
        {
            if (sortDirection == 1)
            {
                LastNames = LastNames.OrderBy(x => x).ToList();
            }
            else
            {
                LastNames = LastNames.OrderByDescending(x => x).ToList();
            }

            foreach (var item in LastNames)
            {
                Console.WriteLine(item);
            }
        }

        public void Sort(int sortDirection)
        {
            if (sortDirection != 0 && sortDirection != 1)
            {
                throw new ArgumentOutOfRangeException($"{nameof(sortDirection)} must be 0 or 1");
            }
            LastNameAdded?.Invoke(sortDirection);
        }

        public void AddLastName(string name)
        {
            try
            {
                // validate argument against null end empty string
                if (string.IsNullOrEmpty(name))
                {

                    throw new ArgumentNullException($"Argument can't be null or empty. Argument:{nameof(name)}");
                }

                LastNames.Add(name);

                // Notify that new last name has been added
                // So the sorting should be done
            }
            catch (Exception ex)
            {
                //  print validation error message
                Console.WriteLine(ex.Message);
            }
        }
    }
}
