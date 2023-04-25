using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _02_learn_entity_framework_core.Context;
using _02_learn_entity_framework_core.Models;

namespace webapi.Services
{
    public class CategoriaService : ICategoriaService
    {

        TareasContext dbContext;

        public CategoriaService(TareasContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Categoria> Get()
        {
            return dbContext.Categorias;
        }

        public async Task Save(Categoria categoria)
        {
            await dbContext.AddAsync(categoria);
            await dbContext.SaveChangesAsync();
        }

        public async Task Update(Guid id, Categoria categoria)
        {
            var categoriaActual = dbContext.Categorias.Find(id);
            if( categoriaActual != null )
            {
                categoriaActual.Nombre = categoria.Nombre;
                categoriaActual.Description = categoria.Description;
                categoriaActual.Peso = categoria.Peso;
                // await dbContext.AddAsync(categoriaActual);
                await dbContext.SaveChangesAsync();
            }
        }
        public async Task Delete(Guid id)
        {
            var categoriaActual = dbContext.Categorias.Find(id);
            if( categoriaActual != null )
            {
                dbContext.Remove(categoriaActual);
                await dbContext.SaveChangesAsync();
            }
        }
    }
    public interface ICategoriaService
    {
        public IEnumerable<Categoria> Get();
        public Task Save(Categoria categoria);
        public  Task Update(Guid id, Categoria categoria);
        public  Task Delete(Guid id);
    }
}