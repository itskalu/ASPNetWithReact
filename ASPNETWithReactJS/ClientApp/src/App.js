import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import FetchData from './components/FetchData';
import Chat from './components/Chat';

import './custom.css'


function App() {
    const displayName = App.name;

    return (
        <Layout>
            <Route exact path='/' component={Home} />
            <Route path='/chat' component={Chat} />
            <Route path='/fetch-data' component={FetchData} />
        </Layout>
    );
}

export default App;
