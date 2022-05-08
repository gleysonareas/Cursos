import React from "react";
import { BrowserRouter as Router, Switch, Route, Link } from "react-router-dom";
import PagesPromotionSearch from "promotion/search/search";

const Root = () => { <
    Router >
        <
        Switch >
        <
        Route path = "/"
    component = { PagesPromotionSearch }
    /> <
    /Switch> <
    /Router>
}

export default Root