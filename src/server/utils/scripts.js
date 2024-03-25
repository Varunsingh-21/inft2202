import {readFile } from 'fs/promises';

export async function reasJson(filename){
    const fileBuffer =  await readFile(filename);
    const fileString = fileBuffer.toString(); 
    const fileJsonReal = JSON.parse(fileString);
    return fileJsonReal;
}


