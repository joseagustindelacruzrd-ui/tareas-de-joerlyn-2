using System.Collections.Generic;
using Microsoft.Data.Sqlite;

public class CentralitaDB
{
    private string connectionString = "Data Source=centralita.db";

    public void CrearTabla()
    {
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();

            string query = @"
                CREATE TABLE IF NOT EXISTS Llamadas (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    NumeroOrigen TEXT NOT NULL,
                    NumeroDestino TEXT NOT NULL,
                    Duracion INTEGER NOT NULL,
                    Costo REAL NOT NULL
                );
            ";

            var command = new SqliteCommand(query, connection);
            command.ExecuteNonQuery();
        }
    }

    public void InsertarLlamada(Llamada llamada)
    {
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();

            string query = @"
                INSERT INTO Llamadas (NumeroOrigen, NumeroDestino, Duracion, Costo)
                VALUES (@origen, @destino, @duracion, @costo);
            ";

            var command = new SqliteCommand(query, connection);
            command.Parameters.AddWithValue("@origen", llamada.NumeroOrigen);
            command.Parameters.AddWithValue("@destino", llamada.NumeroDestino);
            command.Parameters.AddWithValue("@duracion", llamada.Duracion);
            command.Parameters.AddWithValue("@costo", llamada.Costo);

            command.ExecuteNonQuery();
        }
    }

    public List<Llamada> ObtenerLlamadas()
    {
        List<Llamada> lista = new List<Llamada>();

        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();

            string query = "SELECT * FROM Llamadas;";
            var command = new SqliteCommand(query, connection);

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Llamada llamada = new Llamada
                    {
                        Id = reader.GetInt32(0),
                        NumeroOrigen = reader.GetString(1),
                        NumeroDestino = reader.GetString(2),
                        Duracion = reader.GetInt32(3),
                        Costo = reader.GetDecimal(4)
                    };

                    lista.Add(llamada);
                }
            }
        }

        return lista;
    }
}