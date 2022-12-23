import 'bootstrap/dist/css/bootstrap.min.css';
import { Container } from "react-bootstrap";
import Col from "react-bootstrap/esm/Col";
import Row from "react-bootstrap/esm/Row";

import Tab from 'react-bootstrap/Tab';
import Tabs from 'react-bootstrap/Tabs';

import Button from 'react-bootstrap/Button';
import Form from 'react-bootstrap/Form';
import { useState } from 'react';

function App() {
  const [DataRegistroNascimento,setDataRegistroNascimento] = useState(new Date().toISOString());
  return (
    <div className="App">
      <Container fluid="md">
        <Row>
          <Col xs={12} style={{textAlign:"center"}}>
            <Tabs
              defaultActiveKey="profile"
              id="uncontrolled-tab-example"
              className="mb-3 mt-4"
            >
              <Tab eventKey="home" title="Nascimento">
                <Form>
                  <Container>
                    <Row>
                      <Col xs={4}>
                        <Form.Group className="mb-3" controlId="formBasicEmail">
                          <Form.Label>Data Registro</Form.Label>
                          <Form.Control type="date" placeholder="Data de Registro" onChange={(event)=>{setDataRegistroNascimento(new Date(event.target.value).toISOString())}}/>
                        </Form.Group>
                      </Col>
                      <Col xs={4}>
                        <Form.Group className="mb-3" controlId="formBasicPassword">
                          <Form.Label>Data de Nascimento</Form.Label>
                          <Form.Control type="date" placeholder="Data de nascimento" />
                        </Form.Group>
                      </Col>
                      <Col xs={12}> <hr></hr></Col>
                      <Col xs={3}>
                        <Form.Group className="mb-3" controlId="formBasicPassword">
                          <Form.Label>Nome do Registrado</Form.Label>
                          <Form.Control type="text" placeholder="Nome do Registrado" />
                        </Form.Group>
                      </Col>
                      <Col xs={3}>
                        <Form.Group className="mb-3" controlId="formBasicPassword">
                          <Form.Label>Nome do Pai</Form.Label>
                          <Form.Control type="text" placeholder="Nome do Registrado" />
                        </Form.Group>
                      </Col>
                      <Col xs={3}>
                        <Form.Group className="mb-3" controlId="formBasicPassword">
                          <Form.Label>Nome da Mãe</Form.Label>
                          <Form.Control type="text" placeholder="Nome do Registrado" />
                        </Form.Group>
                      </Col>
                      <Col xs={3}>
                        <Form.Group className="mb-3" controlId="formBasicPassword">
                          <Form.Label>Data de Nascimento do Pai</Form.Label>
                          <Form.Control type="date" placeholder="Data de nascimento do Pai" />
                        </Form.Group>
                      </Col>
                      <Col xs={3}>
                        <Form.Group className="mb-3" controlId="formBasicPassword">
                          <Form.Label>Data de Nascimento Da Mãe</Form.Label>
                          <Form.Control type="date" placeholder="Data de nascimento da Mãe" />
                        </Form.Group>
                      </Col>
                      <Col xs={3}>
                        <Form.Group className="mb-3" controlId="formBasicPassword">
                          <Form.Label>Cpf do Pai</Form.Label>
                          <Form.Control type="number" placeholder="Nome do Registrado"/>
                        </Form.Group>
                      </Col>
                      <Col xs={3}>
                        <Form.Group className="mb-3" controlId="formBasicPassword">
                          <Form.Label>Cpf da Mãe</Form.Label>
                          <Form.Control type="number" placeholder="Nome do Registrado" />
                        </Form.Group>
                      </Col>
                    </Row>
                  </Container>
                  <Button variant="primary" type="submit">
                    Submit
                  </Button>
                </Form>
              </Tab>
              <Tab eventKey="profile" title="Casamento">
                <Form>
                  <Container>
                    <Row>
                      <Col xs={4}>
                        <Form.Group className="mb-3" controlId="formBasicEmail">
                          <Form.Label>Data Registro</Form.Label>
                          <Form.Control type="date" placeholder="Data de Registro" />
                        </Form.Group>
                      </Col>
                      <Col xs={4}>
                        <Form.Group className="mb-3" controlId="formBasicPassword">
                          <Form.Label>Data do Casamento</Form.Label>
                          <Form.Control type="date" placeholder="Data de Casamento" />
                        </Form.Group>
                      </Col>
                      <Col xs={12}><Form.Label>Conjuge 1</Form.Label> <hr></hr></Col>
                      <Col xs={4}>
                        <Form.Group className="mb-3" controlId="formBasicPassword">
                          <Form.Label>Nome</Form.Label>
                          <Form.Control type="text" placeholder="Nome do Conjugue 1" />
                        </Form.Group>
                      </Col>
                      <Col xs={4}>
                        <Form.Group className="mb-3" controlId="formBasicPassword">
                          <Form.Label>Data de Nascimento</Form.Label>
                          <Form.Control type="date" placeholder="Data de Nascimento" />
                        </Form.Group>
                      </Col>
                      <Col xs={4}>
                        <Form.Group className="mb-3" controlId="formBasicPassword">
                          <Form.Label>Cpf</Form.Label>
                          <Form.Control type="Number" placeholder="Data de Nascimento" />
                        </Form.Group>
                      </Col>
                      <Col xs={4}>
                        <Form.Group className="mb-3" controlId="formBasicPassword">
                          <Form.Label>Nome da Mãe</Form.Label>
                          <Form.Control type="text" placeholder="Nome do Registrado" />
                        </Form.Group>
                      </Col>
                      <Col xs={4}>
                        <Form.Group className="mb-3" controlId="formBasicPassword">
                          <Form.Label>Data de Nascimento Da Mãe</Form.Label>
                          <Form.Control type="date" placeholder="Data de nascimento da Mãe" />
                        </Form.Group>
                      </Col>
                      <Col xs={4}>
                        <Form.Group className="mb-3" controlId="formBasicPassword">
                          <Form.Label>Cpf da Mãe</Form.Label>
                          <Form.Control type="number" placeholder="cpf Da mãe" />
                        </Form.Group>
                      </Col>
                      <Col xs={4}>
                        <Form.Group className="mb-3" controlId="formBasicPassword">
                          <Form.Label>Nome do Pai</Form.Label>
                          <Form.Control type="text" placeholder="Nome do Pai" />
                        </Form.Group>
                      </Col>
                      <Col xs={4}>
                        <Form.Group className="mb-3" controlId="formBasicPassword">
                          <Form.Label>Data de Nascimento do Pai</Form.Label>
                          <Form.Control type="date" placeholder="Data de nascimento do Pai" />
                        </Form.Group>
                      </Col>
                      <Col xs={4}>
                        <Form.Group className="mb-3" controlId="formBasicPassword">
                          <Form.Label>Cpf do Pai</Form.Label>
                          <Form.Control type="number" placeholder="Nome do Registrado"/>
                        </Form.Group>
                      </Col>
                      <Col xs={12}><Form.Label>Conjuge 2</Form.Label> <hr></hr></Col>
                      <Col xs={4}>
                        <Form.Group className="mb-3" controlId="formBasicPassword">
                          <Form.Label>Nome</Form.Label>
                          <Form.Control type="text" placeholder="Nome do Conjugue 1" />
                        </Form.Group>
                      </Col>
                      <Col xs={4}>
                        <Form.Group className="mb-3" controlId="formBasicPassword">
                          <Form.Label>Data de Nascimento</Form.Label>
                          <Form.Control type="date" placeholder="Data de Nascimento" />
                        </Form.Group>
                      </Col>
                      <Col xs={4}>
                        <Form.Group className="mb-3" controlId="formBasicPassword">
                          <Form.Label>Cpf</Form.Label>
                          <Form.Control type="Number" placeholder="Data de Nascimento" />
                        </Form.Group>
                      </Col>
                      <Col xs={4}>
                        <Form.Group className="mb-3" controlId="formBasicPassword">
                          <Form.Label>Nome da Mãe</Form.Label>
                          <Form.Control type="text" placeholder="Nome do Registrado" />
                        </Form.Group>
                      </Col>
                      <Col xs={4}>
                        <Form.Group className="mb-3" controlId="formBasicPassword">
                          <Form.Label>Data de Nascimento Da Mãe</Form.Label>
                          <Form.Control type="date" placeholder="Data de nascimento da Mãe" />
                        </Form.Group>
                      </Col>
                      <Col xs={4}>
                        <Form.Group className="mb-3" controlId="formBasicPassword">
                          <Form.Label>Cpf da Mãe</Form.Label>
                          <Form.Control type="number" placeholder="cpf Da mãe" />
                        </Form.Group>
                      </Col>
                      <Col xs={4}>
                        <Form.Group className="mb-3" controlId="formBasicPassword">
                          <Form.Label>Nome do Pai</Form.Label>
                          <Form.Control type="text" placeholder="Nome do Pai" />
                        </Form.Group>
                      </Col>
                      <Col xs={4}>
                        <Form.Group className="mb-3" controlId="formBasicPassword">
                          <Form.Label>Data de Nascimento do Pai</Form.Label>
                          <Form.Control type="date" placeholder="Data de nascimento do Pai" />
                        </Form.Group>
                      </Col>
                      <Col xs={4}>
                        <Form.Group className="mb-3" controlId="formBasicPassword">
                          <Form.Label>Cpf do Pai</Form.Label>
                          <Form.Control type="number" placeholder="Nome do Registrado"/>
                        </Form.Group>
                      </Col>
                    </Row>
                  </Container>
                  <Button variant="primary" type="submit">
                    Submit
                  </Button>
                </Form>
              </Tab>
              <Tab eventKey="contact" title="Obito">
                <Form>
                    <Container>
                      <Row>
                        <Col xs={4}>
                          <Form.Group className="mb-3" controlId="formBasicEmail">
                            <Form.Label>Data Registro</Form.Label>
                            <Form.Control type="date" placeholder="Data de Registro"/>
                          </Form.Group>
                        </Col>
                        <Col xs={4}>
                          <Form.Group className="mb-3" controlId="formBasicPassword">
                            <Form.Label>Data do Obito</Form.Label>
                            <Form.Control type="date" placeholder="Data de obito" />
                          </Form.Group>
                        </Col>
                        <Col xs={12}> <hr></hr></Col>
                        <Col xs={4}>
                          <Form.Group className="mb-3" controlId="formBasicPassword">
                            <Form.Label>Nome do Falecido</Form.Label>
                            <Form.Control type="text" placeholder="Nome do Registrado"/>
                          </Form.Group>
                        </Col>
                        <Col xs={4}>
                          <Form.Group className="mb-3" controlId="formBasicPassword">
                            <Form.Label>Data de Nascimento</Form.Label>
                            <Form.Control type="date" placeholder="Data de nascimento do falecido" />
                          </Form.Group>
                        </Col>
                        <Col xs={4}>
                          <Form.Group className="mb-3" controlId="formBasicPassword">
                            <Form.Label>Nome do Pai</Form.Label>
                            <Form.Control type="text" placeholder="Nome do Registrado" />
                          </Form.Group>
                        </Col>
                        <Col xs={4}>
                          <Form.Group className="mb-3" controlId="formBasicPassword">
                            <Form.Label>Data de Nascimento do Pai</Form.Label>
                            <Form.Control type="date" placeholder="Data de nascimento do Pai" />
                          </Form.Group>
                        </Col>
                        <Col xs={4}>
                          <Form.Group className="mb-3" controlId="formBasicPassword">
                            <Form.Label>Nome da Mãe</Form.Label>
                            <Form.Control type="text" placeholder="Nome do Registrado" />
                          </Form.Group>
                        </Col>
                        <Col xs={4}>
                          <Form.Group className="mb-3" controlId="formBasicPassword">
                            <Form.Label>Data de Nascimento Da Mãe</Form.Label>
                            <Form.Control type="date" placeholder="Data de nascimento da Mãe" />
                          </Form.Group>
                        </Col>
                      </Row>
                    </Container>
                    <Button variant="primary" type="submit">
                      Submit
                    </Button>
                </Form>
                
              </Tab>
            </Tabs>
            <button onClick={()=>{window.alert(DataRegistroNascimento)}}>teste</button>
          </Col>
        </Row>
      </Container>
    </div>
  );
}

export default App;
