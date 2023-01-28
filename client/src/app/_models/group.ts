export interface Group {
    name: string;
    conections: Connection[];
}

export interface Connection {
    connectionId: string;
    username: string;
}