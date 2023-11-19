// Create a new database.
const database = 'EXAMPLE_DB';
use(database);

// Create a new collection.
const collection = 'test_data';
db.createCollection(collection);

// Create a new document in the collection.
db.getCollection('test_data').insertOne(
    {
        "id": 1, 
        "color": "Blue"
    });
db.getCollection('test_data').insertOne(
    {
        "id": 2, 
        "shape": "Square", 
        "height" : 10, 
        "width": 20, });

const data = db.getCollection('test_data').find().toArray();
data // array with all the documents in the collection.

