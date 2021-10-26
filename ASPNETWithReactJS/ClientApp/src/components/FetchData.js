import React, { useState, useEffect } from 'react';



function FetchData() {

    const [fetchedData, setFetchedData] = useState([]);

    const fetchData = () => {
        fetch('weatherforecast', {
            method: 'GET'
        })
            .then(res => res.json())
            .then((result) => {
                setFetchedData(result)
            },
                (error) => {
                    console.log(error)
                }
            )
    }

    useEffect(() => {
        fetchData();
    }, []);

    return (
        <div>
            {fetchedData.map(item =>{
                return (

                    <div style={{ backgroundColor: 'grey', borderRadius: 10, padding: 5, marginBottom: 5, display: 'flex', flexDirection: 'row' }}>
                        <div style={{flex: .5}}>
                            <p>Date: {item.date}</p>
                            <p>Temperature (C): {item.temperatureC}</p>
                            <p>Temperature (F): {item.temperatureF}</p>
                            <p>Summary: {item.summary}</p>
                        </div>
                        <div style={{ flex: .5 }}>
                            <img width="300" height="200" src={item.imageURL} alt="some nice city picture" />;
                        </div>
                    </div>
                    
                )
            })},
        </div>
    )

}


export default FetchData;
