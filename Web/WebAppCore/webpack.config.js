"use strict";

var path = require("path");
const { CleanWebpackPlugin } = require('clean-webpack-plugin');
var config = {
    module: {}
};

var studentConfig = Object.assign(
    {},
    config,
    {
        entry: "./Modules/Student",
        mode: "development",
        output: {
            path: path.resolve(__dirname, "./Modules/Student/dist"),
            filename: "bundle.js"
        },
        resolve: {
            extensions: ['.ts', '.js', '.tsx', '.jsx', '.png']
        },
        devtool: 'source-map',

        //Add the loader for .ts files
        module: {
            rules: [
                {
                    test: /\.tsx?$/,
                    loader: 'awesome-typescript-loader'
                },
                {
                    test: /\.css/,
                    use: [
                        'style-loader', // creates style nodes from JS strings
                        'css-loader' // translates CSS into CommonJS
                    ]
                },
                {
                    test: /\.(png|jpg|gif)$/i,
                    use: [
                        {
                            loader: 'url-loader',
                            options: {
                                limit: 8192,
                            },
                        }
                    ]
                }
            ]
        },
        plugins: [
            new CleanWebpackPlugin()
        ]
    }
);

var loginConfig = Object.assign(
    {},
    config,
    {
        entry: "./Modules/Login",
        mode: "development",
        output: {
            path: path.resolve(__dirname, "./Modules/Login/dist"),
            filename: "bundle.js"
        },
        resolve: {
            extensions: ['.ts', '.js', '.tsx', '.jsx', '.png']
        },
        devtool: 'source-map',

        //Add the loader for .ts files
        module: {
            rules: [
                {
                    test: /\.tsx?$/,
                    loader: 'awesome-typescript-loader'
                },
                {
                    test: /\.css/,
                    use: [
                        'style-loader', // creates style nodes from JS strings
                        'css-loader' // translates CSS into CommonJS
                    ]
                },
                {
                    test: /\.(png|jpg|gif)$/i,
                    use: [
                        {
                            loader: 'url-loader',
                            options: {
                                limit: 8192,
                            },
                        }
                    ]
                }
            ]
        },
        plugins: [
            new CleanWebpackPlugin()
        ]
    }
);

module.exports = [studentConfig, loginConfig];