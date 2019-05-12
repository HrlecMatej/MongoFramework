﻿using MongoDB.Driver.Linq;
using System.Linq;

namespace MongoFramework.Infrastructure.Linq
{
	public interface IMongoFrameworkQueryProvider<TEntity, TOutput> : IQueryProvider where TEntity : class
	{
		IMongoQueryable UnderlyingQueryable { get; }
		EntityProcessorCollection<TEntity> EntityProcessors { get; }
	}
}
