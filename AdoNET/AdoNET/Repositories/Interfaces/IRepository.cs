namespace AdoNET.Repositories.Interfaces
{
    internal interface IRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);
        /// <summary>
        /// SQL`de yeni element yaratmaq uchun istifade olunur
        /// </summary>
        /// <param name="model">Classi dolu gonderin</param>
        void Create(T model);
        void Update(int id, T model);
        void Delete(int id);
    }
}
