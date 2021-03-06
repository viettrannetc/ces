﻿using CES.Database.Models;
using CES.Enums;
using CES.Models.FindPath;
using System.Collections.Generic;
using System.Linq;

namespace CES.Extension
{
	public static class Parser
	{
		public static Node GetNode(this List<Node> Nodes, string name)
		{
			return Nodes.First(n => n.Name == name);
		}

		public static List<Node> Parse(this List<RouteModel> Routes, TransportType TransportType)
		{
			var Nodes = new List<Node>();
			foreach (var item in Routes)
			{
				if (Nodes.Any(n => n.Name == item.Start && n.Transportation == item.Transportation)) continue;

				var node = new Node() { Id = item.Id, Name = item.Start };
				Nodes.Add(node);
			}

			foreach (var item in Nodes)
			{
				var connectedRoutes = Routes.Where(r => r.Start == item.Name).ToList();

				foreach (var edge in connectedRoutes)
				{
					var newEdge = new Edge
					{
						Cost = TransportType == TransportType.Fastest 
							? edge.TotalHours
							: edge.Price,
						Price = edge.Price,
						Time = edge.TotalHours,
						ConnectedNode = Nodes.First(n => n.Name == edge.Destination),
						Transportation = edge.Transportation
					};
					item.Connections.Add(newEdge);
				}
			}

			return Nodes;
		}
	}
}
